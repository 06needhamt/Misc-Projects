using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delete
{
    class Program
    {
        static string dir = @"C:\Users\Tom\Desktop\test directory";
        static void Main(string[] args)
        {
            string[] files = System.IO.Directory.GetFiles(dir); // array to hold the file names of the files in the directory
            string[] directories = System.IO.Directory.GetDirectories(dir); // array to hold all the subdirectories
            string nextdirectory = Convert.ToString(System.IO.Directory.GetCurrentDirectory().ElementAt(0)); // get the first subdirectory from within the root directory.
            if (!IsDirectoryEmpty(dir)) // if the root directory is not empty
            {
                Console.WriteLine("Deleting Files");
                for (int count = 0; count < files.Length; count++)
                {
                    if (System.IO.Directory.EnumerateFiles(dir).Count() != 0) // if there are files in the root directory
                    {
                        System.IO.File.Delete(files[count]); // Delete the files
                    }
                    directories = System.IO.Directory.GetDirectories(dir).ToArray(); // get all of the subdirectories and put them into an array
                    if (directories.Length != 0) // there are directories.
                    {
                        files = System.IO.Directory.GetFiles(nextdirectory); // go to the next directory in the array and look for files.
                        count--; // decrement count so we are looking at the 1st element of the array
                        for (int i = 0; i < files.Length; i++)
                        {
                            System.IO.File.Delete(files[count]); // if there are files in the array delete them.
                        }
                    }
                   
                    for (int i = 0; i < directories.Length - 1; i++ )
                    {
                        System.IO.Directory.Delete(directories[i]); // delete all subdirectories
                    }
                    //System.IO.Directory.Delete(nextdirectory);
                    System.IO.Directory.Delete(dir); // delete the root directory
                   
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
