using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HourException : Exception
    {
        public HourException() { }

        public HourException(string message) : base(message) {

        }
    }
}
