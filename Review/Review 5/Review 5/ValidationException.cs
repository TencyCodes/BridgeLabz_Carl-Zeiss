using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
       public class ValidationException : ApplicationException
        {
            public ValidationException(string message) : base(message) { }
        }
}
