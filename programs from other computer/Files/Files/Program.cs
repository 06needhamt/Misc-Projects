using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Files
{
    class Program
    {
        static string sourcedir = @"C:\Users\Thomas\Documents\c++"; // variable to hold the directory to be searched for files
        static string destinationdir = @"C:\mozilla-source"; // variable to hold the directory to save the found files to
        static string filetypes = "*.*"; // variable to hold the types of files to look for

        static void Main(string[] args)
        {
            char choice; // variable to hold the users input Y/N

            Console.ForegroundColor = ConsoleColor.White; // Change the console text colour to White
            Console.WriteLine("Do you want the save directory emptying  Y/N"); // ask the user whether they want the save directory emptying
            choice = Convert.ToChar(Console.ReadLine()); // Read the users input 
            if (choice == 'y' || choice == 'Y') // if the user inputted Y
            {
                EmptyDirectory(); // Go ahead and empty the directory
            }
            else if (choice == 'n' || choice == 'N') // if the user inputted N
            {
                FindFiles(); //Skip emptying the directory and just look for files
            }
            else // if the user entered anything else
            {
                Environment.Exit(0); // Exit the program
            }

        }

        private static void EmptyDirectory() // void to empty the save directory
        {
            string[] files = System.IO.Directory.GetFiles(destinationdir); // array to hold the file names of the files in the directory

            if (IsDirectoryEmpty(destinationdir) == false) // if the save directory is not empty
            {
                for (int count = 0; count < files.Length; count++)
                {
                    System.IO.File.Delete(files[count]); // Delete the files
                }
                FindFiles(); // look for files
            }
            else // if the save directory is already empty
            {
                FindFiles(); // Look for files
            }
        }

        private static bool IsDirectoryEmpty(string path) //bool to check if there are any files in the save directory
        {
            return !System.IO.Directory.EnumerateFileSystemEntries(path).Any(); // Returns TRUE if there are files in the directory, returns FALSE if the directory is empty
        }

        private static void FindFiles() // void to find files
        {
            long foundfiles = 0; // variable to store the amount of files found
            string[] files = System.IO.Directory.GetFiles(destinationdir); // Array to hold the names of files currently in the save directory
            string[] filetypesfound = new string[10000000]; // Array of 1000000 strings to hold the types of all the files found
            string[] filetypesinarray = new string[10000000]; // Array of 1000000 strings to hold the different types of all the files found
            Console.WriteLine("Finding Files"); // Tell the user that the program is finding files

            foreach (var file in new System.IO.DirectoryInfo(sourcedir).GetFiles(filetypes, System.IO.SearchOption.AllDirectories)) // Loop to collect all of the files that match the user's criteria
            {
                try
                {
                    file.CopyTo(System.IO.Path.Combine(destinationdir, file.Name)); // Try to copy the file to the save Directory
                }
                catch (Exception ex) // if an error occurs
                {
                    Console.ForegroundColor = ConsoleColor.Red; // change the text colour to red to inficate an error
                    Console.WriteLine(ex.StackTrace); // Write the Stack Trace to the screen to help describe the error
                    continue; // Continue finding files
                }
                Console.ForegroundColor = ConsoleColor.White; // Change the text colour to white for standard text
                filetypesfound[foundfiles] = getFileType(file.Extension); // put the file type into the file types array
                foundfiles++; // increment the amount of files found
                Console.WriteLine(file.Name); // write the file name to the screen
            }

            filetypesfound = filetypesfound.Where(x => !string.IsNullOrEmpty(x)).ToArray(); // delete all of the null or empty elements from the file types array

            for (long count3 = 0; count3 < filetypesfound.Length; count3++) // loop to find all of the different file types found
            {
                if (filetypesinarray.Contains(filetypesfound[count3])) // if the type has already been found 
                {
                    continue; // continue searching
                }
                else // if it has not already been found
                {
                    filetypesinarray[count3] = filetypesfound[count3]; // insert it into the found file types array
                }
            }

            filetypesinarray = filetypesinarray.Where(x => !string.IsNullOrEmpty(x)).ToArray(); // delete all of the null or empty elements from the found file types array

            Array.Sort(filetypesinarray); // Sort the found file types array into alphabetical order
            if (foundfiles != 0) // if files are found
            {
                Console.WriteLine("Files Found"); // Tell the user that files have been found
                Console.WriteLine("File types found :"); // tell the user the file types that have been found
                Console.WriteLine(); // leave a blank line
                for (long count4 = 0; count4 < filetypesinarray.Length; count4++) // loop to get all of the different file types found
                {
                    Console.WriteLine(filetypesinarray[count4]); // display all of the file types found
                }
            }
            else
            {
                Console.WriteLine("No files found"); // tell the user that no files were found
            }

            Console.WriteLine("Press any key to exit"); // tell the user to press any key to exit
            Console.ReadLine(); // wait for the user to press a key
            // program exits
        }

        private static string getFileType(string type) // String to get the file type of the file currently being copied 
        //(Parameters string type) the file type
        {
            return type; // return the type
        }

    }
}


