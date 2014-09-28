using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Parser
    {
        int[] numericaltypes = { 0, 3, 4, 5, 6, 9, 11 };
        int[] alphanumericaltypes = { 1, 8 };
        List<ASTBranch<dynamic, dynamic, dynamic, dynamic>> branches;
        AST<dynamic, dynamic, dynamic, dynamic> tree;

        public Parser()
        {

        }
        public Parser(AST<dynamic, dynamic, dynamic, dynamic> tree)
        {
            this.tree = tree;
            this.branches = tree.ASTbranches;
            foreach (ASTBranch<dynamic, dynamic, dynamic, dynamic> branch in branches)
            {
                if (IsNumerical(branch.type))
                {
                    CreateNumericalInstruction(branch.type, branch.operation, branch.name, branch.Value);
                }
                else if (isAlphaNumerical(branch.type))
                {
                    CreateAlphaNumericalInstruction(branch.type, branch.operation, branch.name, branch.Value);
                }
                else
                {
                    CreateBinaryInstruction(branch.type, branch.operation, branch.name, branch.Value);
                }
            }
        }
        private void SetBranches()
        {
            this.branches = this.tree.ASTbranches;
        }
        private List<ASTBranch<dynamic, dynamic, dynamic, dynamic>> GetBranches()
        {
            return this.branches;
        }
        private void CreateNumericalInstruction(EnumTypes Type, EnumOperator operation, string name, dynamic val)
        {
            List<string> ops = new List<string>(0);
            DefineVariable(Type, name, null);

            switch (operation)
            {
                case EnumOperator.UNARY_PLUS:
                    {
                        for (int i = 0; i < branches.Count; i++)
                        {
                            if (Regex.IsMatch((string)branches.ElementAt(i).Value, "([0-9])"))
                            {
                                ops.Add((string)branches.ElementAt(i).Value);
                                //if(Regex.IsMatch((string)this.tree.getroot(tree).Value,"([0-9])"))
                                //{
                                //    ops.Add((string)this.tree.getroot(tree).Value);
                                //}
                                for (int j = 0; j < this.tree.ASTbranches.Count; j++)
                                {
                                    if (Regex.IsMatch((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value, "([0-9])"))
                                    {
                                        ops.Add((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
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
                                catch (InvalidOperationException ex)
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
                    
                case EnumOperator.UNARY_MINUS:
                    {
                        for (int i = 0; i < branches.Count; i++)
                        {
                            if (Regex.IsMatch((string)branches.ElementAt(i).Value, "([0-9])"))
                            {
                                ops.Add((string)branches.ElementAt(i).Value);
                                //if(Regex.IsMatch((string)this.tree.getroot(tree).Value,"([0-9])"))
                                //{
                                //    ops.Add((string)this.tree.getroot(tree).Value);
                                //}
                                for (int j = 0; j < this.tree.ASTbranches.Count; j++)
                                {
                                    if (Regex.IsMatch((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value, "([0-9])"))
                                    {
                                        ops.Add((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
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
                                catch (InvalidOperationException ex)
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
                        Instruction ins = new Instruction((int)EnumOpcodes.SUB, ops.ToArray<string>());
                        break;
                    }
                case EnumOperator.UNARY_MULTIPLY:
                    {
                        bool issigned = false;
                        for (int i = 0; i < branches.Count; i++)
                        {
                            if (Regex.IsMatch((string)branches.ElementAt(i).Value, "([0-9])"))
                            {
                                if ((int)branches.ElementAt(i).Value < 0)
                                {
                                    issigned = true;
                                }
                                ops.Add((string)branches.ElementAt(i).Value);
                                //if(Regex.IsMatch((string)this.tree.getroot(tree).Value,"([0-9])"))
                                //{
                                //    ops.Add((string)this.tree.getroot(tree).Value);
                                //}
                                for (int j = 0; j < this.tree.ASTbranches.Count; j++)
                                {
                                    if (Regex.IsMatch((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value, "([0-9])"))
                                    {
                                        ops.Add((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
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
                                catch (InvalidOperationException ex)
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
                        if (issigned)
                        {
                            Instruction ins = new Instruction((int)EnumOpcodes.IMUL, ops.ToArray<string>());
                        }
                        else
                        {
                            Instruction ins = new Instruction((int)EnumOpcodes.MUL,ops.ToArray<string>());
                        }
                        
                        break;
                    }
                case EnumOperator.UNARY_DIVIDE:
                    {
                        bool issigned = false;
                        for (int i = 0; i < branches.Count; i++)
                        {
                            if (Regex.IsMatch((string)branches.ElementAt(i).Value, "([0-9])"))
                            {
                                if ((int)branches.ElementAt(i).Value < 0)
                                {
                                    issigned = true;
                                }
                                ops.Add((string)branches.ElementAt(i).Value);
                                //if(Regex.IsMatch((string)this.tree.getroot(tree).Value,"([0-9])"))
                                //{
                                //    ops.Add((string)this.tree.getroot(tree).Value);
                                //}
                                for (int j = 0; j < this.tree.ASTbranches.Count; j++)
                                {
                                    if (Regex.IsMatch((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value, "([0-9])"))
                                    {
                                        ops.Add((string)this.tree.ASTbranches.ElementAt<ASTBranch<dynamic, dynamic, dynamic, dynamic>>(j).Value);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
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
                                catch (InvalidOperationException ex)
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
                        if (issigned)
                        {
                            Instruction ins = new Instruction((int)EnumOpcodes.IDIV, ops.ToArray<string>());
                        }
                        else
                        {
                            Instruction ins = new Instruction((int)EnumOpcodes.DIV, ops.ToArray<string>());
                        }
                        break;
                    }
            }
            return;
            

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
            return (numericaltypes.Contains<int>(Convert.ToInt32(Type)));
        }

        private bool isAlphaNumerical(EnumTypes Type)
        {
            return (alphanumericaltypes.Contains<int>(Convert.ToInt32(Type)));
        }
        private bool IsBinary(EnumTypes Type)
        {
            return (!alphanumericaltypes.Contains<int>(Convert.ToInt32(Type)) && !numericaltypes.Contains<int>(Convert.ToInt32(Type))) ? true : false;
        }
        protected bool executebranch(ASTBranch<dynamic, dynamic, dynamic, dynamic> branch)
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
