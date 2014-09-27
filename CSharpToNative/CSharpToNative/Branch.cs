using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
        public class Branch<T1, T2>
        {
            //struct properties
            //{
            //    string name;
            //    EnumTypes type;
            //    EnumAccessModifiers protectionlevel;
            //    object Value;
            //}
            public string name;
            public EnumTypes type;
            public EnumAccessModifiers protectionlevel;
            public EnumOperator operation;
            public object Value;
            public Branch<T1, T2> parent = null;
            ///public long depth;

            public Branch()
            {
                //try
                //{
                //    throw new InvalidOperationException("Cannot Create a branch without tokens");
                //}
                //catch (InvalidOperationException ex)
                //{
                //    Console.ForegroundColor = ConsoleColor.DarkRed;
                //    Console.WriteLine(ex.Message);
                //    Console.WriteLine(ex.StackTrace);
                //    Console.ResetColor();
                //}
            }
            public Branch(string[] tokens)
            {
                this.protectionlevel = (EnumAccessModifiers)Convert.ToInt32(tokens[0]);
                this.type = ((EnumTypes)Convert.ToInt32(tokens[1]));
                this.name = tokens[2];
                this.Value = tokens[4];

            }

            private EnumAccessModifiers getaccessmodifier(Branch<T1, T2> branch)
            {
                return branch.protectionlevel;
            }

            private EnumTypes gettype(Branch<T1, T2> branch)
            {
                return branch.type;

            }

            private string getname(Branch<T1, T2> branch)
            {
                return branch.name;
            }

            private object getvalue(Branch<T1, T2> branch)
            {
                return branch.Value;
            }

            protected Branch<T1, T2> Union(Branch<T1, T2> lhs, Branch<T1, T2> rhs)
            {
                if (lhs.Equals(rhs))
                {
                    return lhs;
                }
                else
                {
                    if (lhs.gettype(lhs) != rhs.gettype(rhs))
                    {
                        try
                        {
                            throw new TypeMismatchException();
                        }
                        catch (TypeMismatchException ex)
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
                            Console.WriteLine("A FATAL ERROR HAS OCCURED IN UNION OF BRANCHES: TYPES DO NOT MATCH EXITING");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2500);
                            Environment.Exit(-1);
                        }
                        return null;
                    }
                    else
                    {
                        Branch<T1, T2> newbranch = new Branch<T1, T2>(Lexer.pubtokens);
                        newbranch.type = lhs.type;
                        newbranch.name = lhs.name;
                        newbranch.protectionlevel = rhs.protectionlevel;
                        newbranch.Value = lhs.Value;
                        return newbranch;
                    }
                }
            }
        }
    }

