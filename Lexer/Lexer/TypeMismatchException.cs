using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Exception;

namespace Lexer
{
    [Serializable]
    public class TypeMismatchException : Exception 
    {
        public TypeMismatchException()
        {
            
        }
        public TypeMismatchException(string message)
        {
            
        }
        public override string Message
        {
            get
            {
                return "Type Operands Do not matvh";
            }
        }
        public override string ToString()
        {
            return this.GetType() + this.Message;
        }
    }
}
