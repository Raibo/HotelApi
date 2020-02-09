using System;
using System.Collections.Generic;

namespace HappyTravelTest.Models
{
    public partial class Distributedcache
    {
        public string Id { get; set; }
        public byte[] Value { get; set; }
        public DateTime? ExpiresAtTime { get; set; }
        public double? SlidingExpirationInSeconds { get; set; }
        public DateTime? AbsoluteExpiration { get; set; }
    }
}
