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
        int[] alphanumericaltypes = { 1, 8 };
        List<ASTBranch<dynamic, dynamic, dynamic, dynamic>> branches;
        AST<dynamic, dynamic, dynamic, dynamic> tree;

        private void SetBranches()
        {
            branches = tree.ASTbranches;
        }
        private List<ASTBranch<dynamic,dynamic,dynamic,dynamic>> GetBranches()
        {
            return branches;
        }
        private void CreateNumericalInstruction(EnumTypes Type , EnumOperator operation , string name, dynamic val)
        {
            List<string> ops = new List<string>(0);
            DefineVariable(Type,name,null);

            switch (operation)
            {
                case EnumOperator.UNARY_PLUS:
                    {
                        for (int i = 0; i < branches.Count; i++)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch((string)branches.ElementAt(i).Value, "([0-9])"))
                            {
                                ops.Add((string)branches.ElementAt(i).Value);
                            }
                            else
                            {
                                continue;
                            }
                            if (ops.Count < 1)
                            {
                                try
                                {
                                    throw new InvalidOperationException("Cannot Create Specified instruction type with no operands");
                                }
                                catch(InvalidOperationException ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(ex.GetType());
                                    Console.WriteLine(ex.Message);
                                    Console.WriteLine(ex.StackTrace);
                                    Console.ResetColor();
                                }
                                finally
                                {
                                     Console.ForegroundColor = ConsoleColor.Magenta;
                                     Console.WriteLine("A FATAL ERROR HAS OCCURED DURING CODE GENERATION : CANNOT CREATE INSTRUCTION WITHOUT AN OPCODE OR OPERANDS ");
                                     Console.ResetColor();
                                     System.Threading.Thread.Sleep(2500);
                                     Environment.Exit(-1);
                                }

                            }
                        }
                        Instruction ins = new Instruction((int)EnumOpcodes.ADD, ops.ToArray<string>());
                        break;
                    }
            }
                    return;
                    // not sure 
            
        }

        private void CreateAlphaNumericalInstruction(EnumTypes Type, EnumOperator operation, string name, dynamic val)
        {
            DefineVariable(Type, name, null);
           
        }
        private void CreateBinaryInstruction(EnumTypes Type, EnumOperator operation, string name, dynamic val)
        {
            DefineVariable(Type, name, null);
            
        }
        private int GetOperation(EnumOperator Operator)
        {
            return (int)Operator;
        }

        private static dynamic DefineVariable(EnumTypes Type, string name, dynamic val = null)
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

        private bool isAlphaNumerical(EnumTypes Type)
        {
            return (alphanumericaltypes.Contains<int>(Convert.ToInt32(Type)));
        }
        private bool IsBinary(EnumTypes Type)
        {
            return (!alphanumericaltypes.Contains<int>(Convert.ToInt32(Type)) && !numericaltypes.Contains<int>(Convert.ToInt32(Type))) ? true : false;
        }
         protected bool executebranch(ASTBranch<dynamic,dynamic,dynamic,dynamic> branch)
         {
            string varname = branch.name;
            EnumTypes type = branch.type;
            EnumOperator operation = branch.operation;
            Object value = branch.Value;
            if (IsNumerical(type))
            {
                CreateNumericalInstruction(type, operation, varname, value);
            }
            else if (isAlphaNumerical(type))
            {
                CreateAlphaNumericalInstruction(type, operation, varname, value);
            }
            else
            {
                CreateBinaryInstruction(type, operation, varname, value);
            }
            return false;
        }
    }
}
