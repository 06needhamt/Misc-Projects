using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Lexer
    {
        public static string[] pubtokens;
        private static List<string> operators = new List<string>(new string[] { "=", "!=", "==", "+", "-", "*", "/", "++#", "#++", "--#", "#--", ">", "<", ">=", "<=", "&&", "&", "||", "|", "!", "~", "^", "+=", "-=", "*=", "/=", "<<", ">>", "%=", "&=", "|=", "^=", "<<=", ">>=", "?:", ".", "," });
        private static List<string> keywords = new List<string>(new string[] { "public", "protected", "private", "const", "volatile", "unsigned", "unsafe", "new", "continue", "break", "for", "if", "else", "else if", "while", "do", "class", "enum", "interface", "private static", "void" });
        private static List<string> types = new List<string>(new string[] { "int", "string", "bool", "double", "float", "long", "short", "byte", "char", "decimal", "date", "single", "object" });
        private static string[] lines;
        private static List<EnumOperator> ops = new List<EnumOperator>(1);
        private static List<EnumKeywords> kywrds = new List<EnumKeywords>(1);
        private static List<EnumTypes> typedefs = new List<EnumTypes>(1);
        private static List<string> usertypedefs = new List<string>(1);
        private static System.IO.StreamWriter writer;
        private static string[] lhs;
        private static bool isafunction = false;
        private static List<Tuple<string>> integersymboltable = new List<Tuple<string>>(1);
        private static List<Tuple<string>> stringsymboltable = new List<Tuple<string>>(1);
        private static List<Tuple<string, string>> functionsymboltable = new List<Tuple<string, string>>(1);

        public static void Start(ref string[] linespar, ref int i, System.IO.StreamWriter writerpar)
        {
            lines = linespar;
            writer = writerpar;
            if (!checkkeywords(ref i) || !checkoperators(ref i) || !checktypes(ref i))
            {
                Console.Error.Write("Invalid Input");

            }
            System.Threading.Thread.Sleep(100);
            Console.WriteLine(checkkeywords(ref i));
            System.Threading.Thread.Sleep(100);
            Console.WriteLine(checkoperators(ref i));
            System.Threading.Thread.Sleep(100);

            printTokens(lhs);
            writer.WriteLine();
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
            bool accessmodifier = false;
            for (int j = 0; j < keywords.Count; j++)
            {
                if (lines[i].Contains(keywords[j]))
                {
                    if(j <= 2 && !accessmodifier)
                    {
                        accessmodifier = true;
                    }
                    else if (j <= 2 && accessmodifier)
                    {
                        Console.WriteLine(" ERROR Too many access modifiers");
                        Environment.Exit(-1);
                    }

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
                        Console.WriteLine("lhs " + str + " = " + lhs[str]);
                    }
                }
                
            }
            typedefs.Clear();
            return (ctypes > 0) ? true : false;
        }

        private static bool isvardeclared(ref string[] tokens , ref int i)
        {
            string type = tokens.FirstOrDefault<string>(j => types.Contains(j));
            if ((Object)type == null && i < tokens.Length - 1)
            {
                int j = i;
                for (int m = 0; m < tokens.Length; m++ )
                {
                    Console.WriteLine(tokens[m]);
                }
                Console.ReadKey();
                    j++;
                isvardeclared(ref tokens, ref j);

                if (type.Equals("string"))
                {
                    System.Threading.Thread.Sleep(50);
                    return stringsymboltable.Contains(new Tuple<string>(tokens[i])) ? true : false;
                }
                else if (type.Equals("int"))
                {
                    System.Threading.Thread.Sleep(50);
                    return (integersymboltable.Contains(new Tuple<string>(tokens[i])) ? true : false);
                }
                else
                {
                    System.Threading.Thread.Sleep(50);
                    return false;
                }

            }
            else
            {
                return false;
            }
            
        }

        private static bool checkisafunction(ref string[] tokens , ref int i)
        {
            return (tokens[i].Contains("()")) ? true : false;
        }
        private static void printTokens(string[] tokens )
        {
            int index;
            //bool keyword = false;
            pubtokens = tokens;
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
                        
                            integersymboltable.Add(new Tuple<string>(tokens[i + 1]));
                            for (int j = 0; j < integersymboltable.Count; j++)
                            {
                                Console.WriteLine(integersymboltable.ElementAt<Tuple<string>>(j));
                                //Console.ReadKey();
                            }

                     }

                    else if ((EnumTypes) index == EnumTypes.STRING)
                    {
                        stringsymboltable.Add(new Tuple<string>(tokens[i + 1]));
                        for (int j = 0; j < stringsymboltable.Count; j++)
                        {
                            Console.WriteLine(stringsymboltable.ElementAt<Tuple<string>>(j));
                            //Console.ReadKey();
                        }
                    }
                    else
                    {
                        try
                        {
                            throw new TypeMismatchException(" FATAL ERROR " + tokens[i] + "Is the incorrect type for this variable");
                        }
                        catch (TypeMismatchException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                            Environment.Exit(-1);
                        }
                        
                    }
                    Console.WriteLine((EnumTypes)index);
                    writer.Write((EnumTypes)index);
                    writer.Write(',');
                }

                else if (tokens[i].Equals(" ") || tokens[i].Equals("") || tokens[i].Equals(null))
                {
                    continue;
                }

                else if (System.Text.RegularExpressions.Regex.IsMatch(tokens[i], "([0-9])"))
                {
                    writer.Write("INTVALUE(" + tokens[i] + ")");
                    continue;

                }

                else if (tokens[i].Equals("\n"))
                {
                    return;
                }

                else if (!System.Text.RegularExpressions.Regex.IsMatch(tokens[i], "([0-9])"))
                {
                    Console.WriteLine("Tokens i =  " + tokens[i]);
                    if ((tokens[0].Equals(EnumKeywords.PRIVATE.ToString().ToLower()) || tokens[0].Equals(EnumKeywords.PUBLIC.ToString().ToLower()) || tokens[0].Equals(EnumKeywords.PROTECTED.ToString().ToLower())) /*&& !isvardeclared(ref tokens,ref i)*/)
                    {
                        defineVariable(ref tokens, ref i);
                        continue;
                    }
                    if (isvardeclared(ref tokens, ref i))
                    {
                        writer.Write(tokens[i]);
                        writer.Write(',');
                    }
                    else
                    {
                        isafunction = checkisafunction(ref tokens, ref i);
                        if (isafunction)
                        {
                            string[] funcsplit = tokens[i].Split(new char[] { '(', ')', ' ' });
                            
                            if (!functionsymboltable.Contains(new Tuple<string, string>(funcsplit[0], funcsplit[1])))
                            {
                                functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                                for (int j = 2; j < funcsplit.Length; j++)
                                {
                                    writer.Write(funcsplit[j]);
                                }
                            }
                            else
                            {
                                //functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                                //Console.WriteLine(functionsymboltable.ElementAt<Tuple<string, string>>(0));
                                writer.Write(tokens[i]);
                                continue;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Fatal Error " + tokens[i] + " Is not Declared");
                            Console.ResetColor();
                            return;
                        }

                    }
                    //writer.Write(',');
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

        private static void defineVariable(ref string[] tokens, ref int i)
        {
            EnumTypes type;
            string name = tokens[i];
            if (tokens[i-1].Equals(EnumTypes.INT.ToString().ToLower()))
            {
                integersymboltable.Add(new Tuple<string>(name));
                writer.Write(name);
                writer.Write(',');
                return;
            }
            else if (tokens[i - 1].Equals(EnumTypes.STRING.ToString().ToLower()))
            {
                stringsymboltable.Add(new Tuple<string>(name));
                writer.Write(name);
                writer.Write(',');
                return;
            }
            else
            {
                isafunction = checkisafunction(ref tokens, ref i);
                if (isafunction)
                {
                    string[] funcsplit = tokens[i].Split(new char[] { '(', ')', ' ' });

                    if (!functionsymboltable.Contains(new Tuple<string, string>(funcsplit[0], funcsplit[1])))
                    {
                        functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                        for (int m = 0; m < funcsplit.Length; m++)
                        {
                            Console.WriteLine(funcsplit[m]);
                        }
                        if (string.IsNullOrWhiteSpace(funcsplit[1]))
                        {
                            funcsplit[1] = EnumKeywords.VOID.ToString();
                        }
                        writer.Write(funcsplit[0] + "(" + funcsplit[1] + ")");
                        writer.Write(',');
                    }
                    else
                    {
                        //functionsymboltable.Add(new Tuple<string, string>(funcsplit[0], funcsplit[1]));
                        //Console.WriteLine(functionsymboltable.ElementAt<Tuple<string, string>>(0));
                        writer.Write(tokens[i]);
                        writer.Write(',');
                        return;
                    }
                }
            }
         
        }
    }
}
