using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace File_Finder
{
    public partial class Form1 : Form
     {
         string sourcedir;
         string destinationdir;
         string filetypes = "*.*";
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(0);
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyDirectory();
            FindFiles();
        }

        private void EmptyDirectory() // void to empty the save directory
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

        private bool IsDirectoryEmpty(string path) //bool to check if there are any files in the save directory
        {
            return !System.IO.Directory.EnumerateFileSystemEntries(path).Any(); // Returns TRUE if there are files in the directory, returns FALSE if the directory is empty
        }


        public long FindFiles()
        {
            long count = 0;

            foreach (var file in new System.IO.DirectoryInfo(sourcedir).GetFiles(filetypes, System.IO.SearchOption.AllDirectories))
            {
                try
                {
                    file.CopyTo(System.IO.Path.Combine(destinationdir, file.Name)); // Try to copy the file to the save Directory
                    listBox1.Items.Add(file.Name);
                    count++;
                    label1.Text = Convert.ToString(count);
                    Application.DoEvents();
                    this.Refresh();
                }
                catch (Exception ex) // if an error occurs
                {
                    Console.ForegroundColor = ConsoleColor.Red; // change the text colour to red to inficate an error
                    listBox1.Items.Add(ex.StackTrace); // Write the Stack Trace to the screen to help describe the error
                    Application.DoEvents();
                    this.Refresh();
                    continue; // Continue finding files
                }
            }
            MessageBox.Show("Files Copied");
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            sourcedir = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog2.ShowDialog();
            textBox2.Text = folderBrowserDialog2.SelectedPath;
            destinationdir = textBox2.Text;
        }
    }
}
