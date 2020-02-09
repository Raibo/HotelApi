using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyTravelTest.Exceptions
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string msg) : base(msg)
        { }
    }
}
