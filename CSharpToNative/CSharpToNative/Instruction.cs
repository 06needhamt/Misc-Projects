using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Instruction
    {
        uint Opcode;
        string[] Operands;

        public Instruction(uint opcode, string[] operands)
        {
            this.Opcode = opcode;
            //string hexop = Convert.ToString(this.Opcode, 16);
            //this.Opcode = int.Parse(hexop, System.Globalization.NumberStyles.HexNumber);
            //string binop = Convert.ToString(this.Opcode,2);
            //this.Opcode = Convert.ToInt32(Convert.ToString(opcode, 10));
            //Console.WriteLine(binop);
            Console.WriteLine(this.Opcode);
            this.Operands = operands;
        }

        public Instruction(uint opcode)
        {
            this.Opcode = opcode;
            //string hexop = Convert.ToString(this.Opcode, 16);
            //this.Opcode = int.Parse(hexop, System.Globalization.NumberStyles.HexNumber);
            //string binop = Convert.ToString(this.Opcode,2);
            //this.Opcode = Convert.ToInt32(Convert.ToString(opcode,10));
            //Console.WriteLine(binop);
            Console.WriteLine(this.Opcode);
            this.Operands = null;
        }

        public Instruction()
        {
            try
            {
                throw new InvalidOperationException("Cannot Create Instruction Without an Opcode or Operands");
            }
            catch (InvalidOperationException ex)
            {
                 Console.ForegroundColor = ConsoleColor.DarkRed;
                 Console.WriteLine(ex.GetType());
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.StackTrace);
                 Console.ResetColor();
            }
            finally
            {
                 Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine("A FATAL ERROR HAS OCCURED DURING CODE GENERATION : CANNOT CREATE INSTRUCTION WITHOUT AN OPCODE OR OPERANDS ");
                 Console.ResetColor();
                 System.Threading.Thread.Sleep(2500);
                 Environment.Exit(-1);
            }
                        
        }
        public uint getOpcode()
        {
            return this.Opcode;
        }

        public string[] getOperands()
        {
            return this.Operands;
        }

        public void printAssemblyInstruction()
        {
            string currentdir = System.Environment.CurrentDirectory + "/";
            string outfile = currentdir + "Output.asm";
            if (System.IO.File.Exists(outfile))
            {
                System.IO.File.Delete(outfile);
            }
            System.IO.File.Create(outfile);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(currentdir + "Output.asm", true);
            //writer.Write(" ");
            if (this.Operands != null)
            {
                writer.Write((EnumOpcodes)this.Opcode);
                writer.Write(" ");
                for (int i = 0; i < this.Operands.Length; i++)
                {
                    writer.Write(this.Operands[i]);
                    //if (i == 0)
                    //{
                    //    writer.Write(" ");
                    //}
                    if (i != Operands.Length - 1)
                    {
                        writer.Write(',');
                    }
                    //writer.Write(",");
                }
                writer.WriteLine();
            }
            else
            {
                writer.Write((EnumOpcodes)this.Opcode);
                writer.WriteLine();
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
            return;
        }
        public void PrintBinaryInstruction()
        {
            string currentdir = System.Environment.CurrentDirectory + "/";
            string outfile = currentdir + "Output.exe";
            if (System.IO.File.Exists(outfile))
            {
                System.IO.File.Delete(outfile);
            }
            else
            {
                System.IO.File.Create(outfile);
            }
            System.IO.StreamWriter writer = new System.IO.StreamWriter(currentdir + "Output.exe", true);
            //writer.Write(" ");
            if (this.Operands != null)
            {
                writer.Write((Convert.ToString(this.Opcode,2)));
                writer.Write(" ");
                for (int i = 0; i < this.Operands.Length; i++)
                {
                    foreach (byte b in this.Operands[i])
                    {
                        writer.Write(Convert.ToString(b, 2));
                        writer.Write(" ");
                    }
                    //writer.Write(",");
                }
                //writer.WriteLine();
            }
            else
            {
                writer.Write((Convert.ToString(this.Opcode, 2)));
                //writer.WriteLine();
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
            return;
        }
    }
}
