using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer
{
    class Program
    {
        //static string outloc;
        static List<string> operators = new List<string>( new string[] { "=", "!=", "==", "+", "-", "*", "/", "++#", "#++", "--#", "#--", ">", "<", ">=", "<=", "&&", "&", "||", "|", "!", "~", "^", "+=", "-=", "*=", "/=", "<<", ">>", "%=", "&=", "|=", "^=", "<<=", ">>=", "?:", ".", "," });
        static List<string> keywords = new List<string> ( new string[] { "public", "protected", "private", "const", "volatile", "unsigned", "unsafe", "new", "continue", "break", "for", "if", "else", "else if", "while", "do", "class", "enum", "interface","static","void" });
        static List<string> types = new List<string>(new string[] { "int", "string", "bool", "double", "float", "long", "short", "byte", "char", "decimal", "date", "single" });
        static string[] lines;
        static List<EnumOperator> ops = new List<EnumOperator>(1);
        static List<EnumKeywords> kywrds = new List<EnumKeywords>(1);
        static List<EnumTypes> typedefs = new List<EnumTypes>(1);
        static System.IO.StreamWriter writer;
        static string[] lhs;
        static string rhs;
        static List<Tuple<string>> integersymboltable = new List<Tuple<string>>(1);
        static List<Tuple<string, string>> functionsymboltable = new List<Tuple<string, string>>(1);
        static void Main(string[] args)
        {
            
            //outloc = args[0] + ".lex";
            writer = new System.IO.StreamWriter(args[0] + ".lex");
            lines = System.IO.File.ReadAllLines(args[0]);
            Console.WriteLine(operators.Count);
            Console.WriteLine(keywords.Count);
            //Console.WriteLine(Convert.ToString((EnumOperator)1));
            for (int i = 0; i < lines.Length; i++)
            {
                if(lines[i].StartsWith("//") || (lines[i].StartsWith("/*") && lines.Contains("*/")))
                {
                    continue;
                }
                Console.WriteLine(lines[i]);
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(checkkeywords(ref i));
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(checkoperators(ref i));
                System.Threading.Thread.Sleep(100);
                //if (!checkkeywords(ref i) || !checkoperators(ref i) || !checktypes(ref i))
                //{
                //    Console.Error.Write("Invalid Input");

                //}
                printTokens(lhs);
                writer.WriteLine();
                
                
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
            Console.WriteLine("Lexical Analasis Complete");
            Console.ReadKey();

        }

        private static bool checkoperators(ref int i)
        {
          
            int cops = 0;
            for (int j = 0; j < operators.Count; j++)
            {
                if (lines[i].Contains(operators[j]))
                {
                    cops++;
                    //lhs = string.Split(new string[] { operators[j] } , 5 , StringSplitOptions.RemoveEmptyEntries)));
                    ops.Add((EnumOperator)j);
                    lhs = lines[i].Split(new char[] { ' ' , ';'});
                    for (int str = -0; str < lhs.Length; str++ )
                    {
                        Console.WriteLine("lhs " + str + "= " + lhs[str]);
                    }
                }
            }

            //for (int k = 0; k < ops.Count; k++)
            //{
            //    Console.WriteLine(Convert.ToString(ops.ElementAt<EnumOperator>(k)));
            //}
            ops.Clear();
            return (cops > 0) ? true : false;

        }


        private static bool checkkeywords(ref int i)
        {
            int ckeywords = 0;
            for (int j = 0; j < keywords.Count; j++)
            {
                if (lines[i].Contains(keywords[j]))
                {
                    ckeywords++;
                    //lhs = string.Split(new string[] { operators[j] } , 5 , StringSplitOptions.RemoveEmptyEntries)));
                    kywrds.Add((EnumKeywords)j);
                    lhs = lines[i].Split(new char[] { ' ', ';' });
                    for (int str = -0; str < lhs.Length; str++)
                    {
                        Console.WriteLine("lhs " + str + "= " + lhs[str]);
                    }
                }
            }

            for (int k = 0; k < kywrds.Count; k++)
            {
                Console.WriteLine(Convert.ToString(kywrds.ElementAt<EnumKeywords>(k)));
            }
            kywrds.Clear();
            return (ckeywords > 0) ? true : false;

        }

        private static bool checktypes(ref int i)
        {
            int ctypes = 0;
            for (int j = 0; j < types.Count; j++)
            {
                if ((lines[i].Contains(types[j])))
                {
                    ctypes++;
                    typedefs.Add((EnumTypes)j);
                    lhs = lines[i].Split(new char[] { ' ', ';' });
                    for (int str = -0; str < lhs.Length; str++)
                    {
                        Console.WriteLine("lhs " + str + "= " + lhs[str]);
                    }
                }
                
            }
            typedefs.Clear();
            return (ctypes > 0) ? true : false;
        }

        private static bool isvardeclared(ref string[] tokens , ref int i)
        {
            return (integersymboltable.Contains(new Tuple<string>(tokens[i])) ? true : false);
        }

        private static bool checkisafunction(ref int i)
        {
            return (lines[i].Contains("()")) ? true : false;
        }
        private static void printTokens(string[] tokens )
        {
            int index;
            //bool keyword = false;
            writer.WriteLine("START");
            for (int i = 0; i < tokens.Length; i++)
            {
                if (keywords.Contains<string>(tokens[i]))
                {
                    //keyword = true;
                    index = keywords.IndexOf(tokens[i]);
                    writer.Write((EnumKeywords)index);
                    Console.WriteLine((EnumKeywords)index);
                    writer.Write(',');
                    continue;
                }

                else if (operators.Contains<string>(tokens[i]))
                {
                    index = operators.IndexOf(tokens[i]);
                    Console.WriteLine((EnumOperator)index);
                    writer.Write((EnumOperator)index);
                    writer.Write(',');
                }
                else if (types.Contains<string>(tokens[i]))
                {
                    index = types.IndexOf(tokens[i]);
                    if ((EnumTypes)index == EnumTypes.INT)
                    {
                        try
                        {
                            integersymboltable.Add(new Tuple<string>(tokens[i + 1]));
                            for (int j = 0; j < integersymboltable.Count; j++)
                            {
                                Console.WriteLine(integersymboltable.ElementAt<Tuple<string>>(j));
                                //Console.ReadKey();
                            }

                        }
                        catch (System.FormatException ex)
                        {
                            Console.Error.WriteLine(" FATAL ERROR Value is not an int");
                            //Console.WriteLine(ex.StackTrace);
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        try
                        {
                            throw new FormatException(" FATAL ERROR Value is not an int");
                        }
                        catch (FormatException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                        }
                        
                    }
                    Console.WriteLine((EnumTypes)index);
                    writer.Write((EnumTypes)index);
                    writer.Write(',');
                }

                else if (tokens[i].Equals(" ") || tokens[i].Equals(""))
                {
                    continue;
                }

                else if (System.Text.RegularExpressions.Regex.IsMatch(tokens[i], "([0-9])"))
                {
                    writer.Write("INTVALUE(" + tokens[i] + ")");

                }

                else if (tokens[i].Equals("\n"))
                {
                    return;
                }

                else if (!System.Text.RegularExpressions.Regex.IsMatch(tokens[i], "([0-9])"))
                {
                    if (isvardeclared(ref tokens, ref i))
                    {
                        writer.Write(tokens[i]);
                        writer.Write(',');
                    }
                //    else
                //    {

                //        if (checkisafunction(ref i))
                //        {
                //            string[] funcsplit = tokens[i].Split(new char[] { '(', ')', ' ' });
                //            if (!functionsymboltable.Contains(new Tuple<string,string>(funcsplit[0],funcsplit[1])))
                //            {
                //                functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                //            }
                //            else
                //            {
                //                //functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                //                Console.WriteLine(functionsymboltable.ElementAt<Tuple<string, string>>(0));
                //                writer.Write(tokens[i]);
                //                continue;
                //            }
                            
                //        }
                //        else
                //        {
                //            Console.WriteLine("Fatal Error " + tokens[i] + " Is not Declared");
                //            return;
                //        }

                //    }
                //    //writer.Write(',');
                }
                else
                {
                    writer.Write(tokens[i]);
                    writer.Write(',');
                }
               
                
            }
            writer.WriteLine();
            writer.WriteLine("END");
            
        }
    }
}