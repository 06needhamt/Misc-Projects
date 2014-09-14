using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class DefineTest
    {
        public static void run()
        {
            dynamic inta = DefineVariable(100);
            dynamic boola = DefineVariable(false);
            dynamic doublea = DefineVariable(12.5);
            dynamic chara = DefineVariable('c');
            dynamic stringa = DefineVariable("Hello World");
            dynamic longa = DefineVariable(25L);
            dynamic floata = DefineVariable(17.5F);
            dynamic datea = DefineVariable(new DateTime(2014, 01, 01));
            Console.WriteLine(inta);
            Console.WriteLine(boola);
            Console.WriteLine(doublea);
            Console.WriteLine(chara);
            Console.WriteLine(stringa);
            Console.WriteLine(longa);
            Console.WriteLine(floata);
            Console.WriteLine(datea);
            
        }
        private static dynamic DefineVariable(Object val = null)
        {
            dynamic memory = val;
            return memory;
        }
    }
}
