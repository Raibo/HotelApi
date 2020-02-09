using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HappyTravelTest.DTO.NetstormingRequestObjects;
using HappyTravelTest.DTO.NetstormingResponseObjects;
using HappyTravelTest.Exceptions;
using HappyTravelTest.Settings;
using Microsoft.Extensions.Options;

namespace HappyTravelTest.Dependencies
{
    public class NetstormingClient : INetstormingClient
    {
        private const string NetstormingErrorResponseTypeName = "error";
        private const string NetstormingErrorNotFoundText = "Unknown hotel ID";
        private readonly NetstormingClientSettings settings;
        public NetstormingClient(IOptions<NetstormingClientSettings> settings)
        {
            this.settings = settings.Value;
        }

        public async Task<NetstormingResponse> GetInfo(int hotelId)
        {
            var timestamp = DateTime.Now.ToFileTime().ToString();
            var request = new NetstormingRequest
            {
                Header = new NetstormingRequestHeader
                {
                    Actor = settings.actor, Password = settings.password, User = settings.user,
                    Version = settings.version, Timestamp = timestamp
                },
                Query = new NetstormingRequestQuery
                {
                    Hotel = new NetstormingRequestHotel {Id = hotelId}, Product = settings.queryProduct,
                    Type = settings.queryType
                }
            };

            var xmlRequestText = SerializeXml(request);

            using var webClient = new WebClient();
            var responseText = await webClient.UploadStringTaskAsync(settings.url, xmlRequestText);
            var response = DeserializeXml<NetstormingResponse>(responseText);

            if (response.response.type == NetstormingErrorResponseTypeName)
                if (response.response.value == NetstormingErrorNotFoundText)
                    throw new NotFoundException("Hotel ID not found in netstorming api");
                else
                    throw new NetstormingException("Unexpected netstorming api error");

            return response;
        }

        string SerializeXml<T>(T obj)
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.OmitXmlDeclaration = true;

            using var stream = new StringWriter();
            using var writer = XmlWriter.Create(stream, xmlWriterSettings);
            new XmlSerializer(typeof(T)).Serialize(writer, obj, emptyNamespaces);

            return stream.ToString();
        }

        T DeserializeXml<T>(string xmlText)
        {
            using var stream = new StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(T));

            var rez = (T)serializer.Deserialize(stream);

            return rez;
        }
    }
}
