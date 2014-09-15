using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Parser
    {
        int[] numericaltypes = { 0, 3, 4, 5, 6, 9, 11 };
        private void CreateInstruction(EnumTypes Type , EnumOperator operation , string name, Object val)
        {
            DefineVariable(Type,name,null);
            if (numericaltypes.Contains<int>(GetOperation(operation)))
            {
                if (operation.Equals(EnumOperator.UNARY_PLUS))
                {
                    return;
                    // not sure 
                }
            }
        }

        private int GetOperation(EnumOperator Operator)
        {
            return (int)Operator;
        }

        private static dynamic DefineVariable(EnumTypes Type, string name, Object val = null)
        {
           // System.Type var = val.GetType();
            dynamic memory = val;
            return memory;
        }

        private bool IsNumerical(EnumTypes Type)
        {
            //int[] numericaltypes = { 0, 3, 4, 5, 6, 9, 11 };
            return (numericaltypes.Contains<int> (Convert.ToInt32(Type)));
        }
         protected bool executebranch(ASTBranch<dynamic,dynamic,dynamic,dynamic> branch)
         {
            string varname = branch.name;
            EnumTypes type = branch.type;
            EnumOperator operation = branch.operation;
            Object value = branch.Value;
            if(IsNumerical(type))
            {
                CreateInstruction(type,operation,varname,value);
            }
            return false;
        }
    }
}
