using System;
using System.Collections.Generic;

namespace HappyTravelTest.Models
{
    public partial class BookingRequestsData
    {
        public int Id { get; set; }
        public string ReferenceCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LanguageCode { get; set; }
        public string BookingRequest { get; set; }
    }
}
