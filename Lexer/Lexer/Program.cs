using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer
{
    class Program
    {
        static string[] operators = { "=", "!=", "==", "+", "-", "*", "/", "++#", "#++", "--#", "#--", ">", "<", ">=", "<=", "&&", "&", "||", "|", "!", "~", "^", "+=", "-=", "*=", "/=", "<<", ">>", "%=", "&=", "|=", "^=", "<<=", ">>=", "?:", ".", "," };
        static string[] keywords = { "public", "protected", "private", "const", "volatile", "unsigned", "unsafe", "new", "continue", "break", "for", "if", "else", "else if", "while", "do", "class", "enum", "interface" };
        static string[] lines;
        static List<EnumOperator> ops = new List<EnumOperator>(1);
        static List<EnumKeywords> kywrds = new List<EnumKeywords>(1);
        
        static void Main(string[] args)
        {
            //fileloc = args[0];
            lines = System.IO.File.ReadAllLines(args[0]);
            Console.WriteLine(operators.Length);
            Console.WriteLine(keywords.Length);
            //Console.WriteLine(Convert.ToString((EnumOperator)1));
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(checkkeywords(ref i));
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(Convert.ToString(checkoperators(ref i)));
                System.Threading.Thread.Sleep(100);
                
            }
            Console.WriteLine("Lexical Analasis Complete");
            Console.ReadKey();

        }

        private static bool checkoperators(ref int i)
        {
            int cops = 0;
            for (int j = 0; j < operators.Length; j++)
            {
                if (lines[i].Contains(operators[j]))
                {
                    cops++;
                    ops.Add((EnumOperator)j);
                }
            }

            for (int k = 0; k < ops.Count; k++)
            {
                Console.WriteLine(Convert.ToString(ops.ElementAt<EnumOperator>(k)));
            }
            ops.Clear();
            return (cops > 0) ? true : false;

        }


        private static bool checkkeywords(ref int i)
        {
            int ckewords = 0;
            for (int j = 0; j < keywords.Length; j++)
            {
                if (lines[i].Contains(keywords[j]))
                {
                    ckewords++;
                    kywrds.Add((EnumKeywords)j);
                }
            }

            for (int k = 0; k < kywrds.Count; k++)
            {
                Console.WriteLine(Convert.ToString(kywrds.ElementAt<EnumKeywords>(k)));
            }
            kywrds.Clear();
            return (ckewords > 0) ? true : false;
        }

    }
}