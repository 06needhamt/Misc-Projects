using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Query();
            noQuery();
            Console.ReadKey();
        }

        private static void noQuery()
        {
            List<string> strlist = new List<string>(1);
            string[] strarray = new string[50];

            for (int i = 0; i < strarray.Length; i += 2)
            {
                strarray[i] = "A";
            }

            for (int j = 0; j < strarray.Length; j++)
            {
                if (strarray[j] != null && strarray[j] != string.Empty)
                {
                    strlist.Add(strarray[j]);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(strlist.Count);
            
        }

        private static void Query()
        {
            List<string> strlist = new List<string>(1);
            string[] strarray = new string[50];

            for (int i = 0; i < strarray.Length; i += 2)
            {
                strarray[i] = "A";
            }

            strlist = strarray.Where(x => !string.IsNullOrEmpty(x)).ToList();
            Console.WriteLine(strlist.Count);
        }
    }
}
