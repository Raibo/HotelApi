using System;
using System.Xml.Serialization;

namespace HappyTravelTest.DTO.NetstormingRequestObjects
{
    [Serializable]
    public class NetstormingRequestHotel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
