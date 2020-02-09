using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyTravelTest.Exceptions
{
    public class NetstormingException : Exception
    {
        public NetstormingException(string msg) : base(msg)
        { }
    }
}
