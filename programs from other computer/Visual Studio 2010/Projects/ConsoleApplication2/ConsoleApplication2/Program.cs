using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[1000];
            int count = 0;

            for (count = 0; count < i.Length - 1; count++)
            {
                while (i[count] < 1000)
                {
                    i[count]++;
                    Console.Write(i[count]);
                }
            }

            
        }
    
    }
}
