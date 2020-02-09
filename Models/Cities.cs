using System;
using System.Collections.Generic;

namespace HappyTravelTest.Models
{
    public partial class Cities
    {
        public string Code { get; set; }
        public string Names { get; set; }
        public string CountryCode { get; set; }
        public bool HasTax { get; set; }
        public DateTime Modified { get; set; }
    }
}
