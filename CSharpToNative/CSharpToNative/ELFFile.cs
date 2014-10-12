using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpToNative
{
    class ELFFile
    {
        byte[] fileheader = new byte[50];
        string currentdir = System.Environment.CurrentDirectory + "/";

        public ELFFile(string name)
        {
            CreateHeader();
            WriteFile(name);
        
        }

        private void WriteFile(string name)
        {
            if (File.Exists(currentdir + name))
            {
                File.Delete(currentdir + name);
            }
            BinaryWriter writer = new BinaryWriter(File.Open(currentdir + name, FileMode.OpenOrCreate,FileAccess.ReadWrite));
            for (int i = 0; i < fileheader.Length; i++)
            {
                writer.Write(fileheader[i]);
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void CreateHeader()
        {
            this.fileheader[0] = 0x7F;
            this.fileheader[1] = 0x45;
            this.fileheader[2] = 0x4C;
            this.fileheader[3] = 0x46;
            this.fileheader[4] = 0x01;
            this.fileheader[5] = 0x02;
            this.fileheader[6] = 0x01;
            this.fileheader[7] = 0x00;
            this.fileheader[8] = 0x08;
            this.fileheader[9] = 0x00;
            this.fileheader[10] = 0x00;
            this.fileheader[11] = 0x00;
            this.fileheader[12] = 0x00;
            this.fileheader[13] = 0x00;
            this.fileheader[14] = 0x00;
            this.fileheader[15] = 0x00;
            this.fileheader[16] = 0x01;
            this.fileheader[17] = 0x00;
            this.fileheader[18] = 0x3E;
            this.fileheader[19] = 0x00;
            this.fileheader[20] = 0x01;
            this.fileheader[21] = 0x00;
            this.fileheader[22] = 0x00;
            this.fileheader[23] = 0x00;
        }
    }
}
