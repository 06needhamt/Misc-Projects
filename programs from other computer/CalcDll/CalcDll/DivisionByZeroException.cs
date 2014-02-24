using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcDll
{
    class DivisionByZeroException : Exception
    {
        public DivisionByZeroException()
        {
           
        }
        public override string ToString()
        {
            return "You can not divide by zero!";
        }
    }
}
