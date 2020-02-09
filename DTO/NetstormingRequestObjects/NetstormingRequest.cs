using System;
using System.Xml.Serialization;

namespace HappyTravelTest.DTO.NetstormingRequestObjects
{
    [Serializable]
    [XmlRoot("envelope")]
    public class NetstormingRequest
    {
        [XmlElement("header")]
        public NetstormingRequestHeader Header { get; set; }

        [XmlElement("query")]
        public NetstormingRequestQuery Query { get; set; }
    }
}
