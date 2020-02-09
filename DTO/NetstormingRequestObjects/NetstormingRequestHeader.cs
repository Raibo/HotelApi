using System;
using System.Xml.Serialization;

namespace HappyTravelTest.DTO.NetstormingRequestObjects
{
    [Serializable]
    public class NetstormingRequestHeader
    {
        [XmlElement("actor")]
        public string Actor { get; set; }

        [XmlElement("user")]
        public string User { get; set; }

        [XmlElement("password")]
        public string Password { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("timestamp")]
        public string Timestamp { get; set; }
    }
}
