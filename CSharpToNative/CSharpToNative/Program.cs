﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Program
    {
        private static List<string> operators = new List<string>(new string[] { "=", "!=", "==", "+", "-", "*", "/", "++#", "#++", "--#", "#--", ">", "<", ">=", "<=", "&&", "&", "||", "|", "!", "~", "^", "+=", "-=", "*=", "/=", "<<", ">>", "%=", "&=", "|=", "^=", "<<=", ">>=", "?:", ".", "," });
        private static List<string> keywords = new List<string>(new string[] { "public", "protected", "private", "const", "volatile", "unsigned", "unsafe", "new", "continue", "break", "for", "if", "else", "else if", "while", "do", "class", "enum", "interface", "private static", "void" });
        private static List<string> types = new List<string>(new string[] { "int", "string", "bool", "double", "float", "long", "short", "byte", "char", "decimal", "date", "single", "object" });
        private static string[] lines;
        private static System.IO.StreamWriter writer;
        private static string currentdir = System.Environment.CurrentDirectory + "/";
        static void Main(string[] args)
        {
             //outloc = args[0] + ".lex";
            //Console.WriteLine(EnumKeywords.PUBLIC.ToString());
            //Console.ReadKey();
            //Environment.Exit(0);
            writer = new System.IO.StreamWriter(currentdir + args[0] + ".lex");
            lines = System.IO.File.ReadAllLines(currentdir + args[0]);
            Console.WriteLine(operators.Count);
            Console.WriteLine(keywords.Count);
            //Console.WriteLine(Convert.ToString((EnumOperator)1));
            for (int i = 0; i < lines.Length; i++)
            {
                //if(System.Text.RegularExpressions.Regex.IsMatch(lines[i], @"//.*|/\*([~/]|\*[~/])*\*+/"));
                //{
                //    continue;
                //}
                if (lines[i].Contains("//"))
                {
                    continue;
                }
                Console.WriteLine(lines[i]);
                Lexer.Start(ref lines, ref i,writer);
            }
            
            writer.Flush();
            writer.Close();
            writer.Dispose();
            Console.WriteLine("Lexical Analasis Complete");
            Console.ReadKey();
        }


    }
}
