using System;
using System.Collections.Generic;

namespace HappyTravelTest.Models
{
    public partial class Hotels
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string CityCode { get; set; }
        public string CountryCode { get; set; }
        public string CityZoneCode { get; set; }
        public string CategoryCode { get; set; }
        public string DescriptionCode { get; set; }
        public string Contacts { get; set; }
        public string Pictures { get; set; }
        public int Rating { get; set; }
        public string Schedule { get; set; }
        public string TextualDescriptions { get; set; }
        public string RoomAmenities { get; set; }
        public string HotelAmenities { get; set; }
        public string AdditionalInfo { get; set; }
        public string LocationDetails { get; set; }
        public DateTime Modified { get; set; }
    }
}
