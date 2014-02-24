using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delete
{
    class Program
    {
        static string dir = @"C:\Users\Thomas\Documents\Adobe CS4";
        static void Main(string[] args)
        {
            string[] files = System.IO.Directory.GetFiles(dir); // array to hold the file names of the files in the directory
            

            if (IsDirectoryEmpty(dir) == false) // if the save directory is not empty
            {
                Console.WriteLine("Deleting Files");
                for (int count = 0; count < files.Length; count++)
                {
                    System.IO.File.Delete(files[count]); // Delete the files
                }
                
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
         private static bool IsDirectoryEmpty(string path) //bool to check if there are any files in the save directory
        {
            return !System.IO.Directory.EnumerateFileSystemEntries(path).Any(); // Returns TRUE if there are files in the directory, returns FALSE if the directory is empty
        }
    }
}
