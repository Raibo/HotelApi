using System;
using System.Xml.Serialization;

namespace HappyTravelTest.DTO.NetstormingRequestObjects
{
    [Serializable]
    public class NetstormingRequestQuery
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("product")]
        public string Product { get; set; }

        [XmlElement("hotel")]
        public NetstormingRequestHotel Hotel { get; set; }
    }
}
