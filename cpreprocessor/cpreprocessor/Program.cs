using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpreprocessor
{
    class Program
    {
        static string[] splitstring;
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory + @"\" + args[0]);
            Console.WriteLine(Environment.CurrentDirectory +  @"\" + args[1]);
            Readfile(Environment.CurrentDirectory +  @"\" + args[0] , Environment.CurrentDirectory + @"\" + args[1]);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void Readfile(string loc , string loc2)
        {
            //System.IO.StreamWriter writer = new System.IO.StreamWriter(loc,true);
            string[] lines = System.IO.File.ReadAllLines(loc);
            foreach (string line in lines)
            {
                if (line.StartsWith("#"))
                {
                    splitstring = line.Split(new char[]{ ' ' });
                    for (int i = 0; i < splitstring.Length; i++)
                    {
                        Console.WriteLine(splitstring[i]);
                        if (splitstring[i].EndsWith(".js"))
                        {
                            System.IO.StreamWriter writer = new System.IO.StreamWriter(loc2, true);
                            string[] includelines = System.IO.File.ReadAllLines(Environment.CurrentDirectory + @"\" + splitstring[i]);
                            foreach (string pline in includelines)
                            {
                                Console.WriteLine(pline);
                                writer.WriteLine(pline);
                                
                            }
                            writer.Flush();
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                }
                else
                {
                    System.IO.StreamWriter writer2 = new System.IO.StreamWriter(loc2, true);
                    writer2.WriteLine(line);
                    writer2.Flush();
                    writer2.Close();
                    writer2.Dispose();
                }
            }
            Console.WriteLine("Preprocessing is Complete");
            return;
        }
    }

}
