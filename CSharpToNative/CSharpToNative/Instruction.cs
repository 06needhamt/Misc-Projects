using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    class Instruction
    {
        int Opcode;
        string[] Operands;

        Instruction(int opcode, string[] operands)
        {
            string hexop = this.Opcode.ToString("X");

            this.Opcode = int.Parse(hexop,System.Globalization.NumberStyles.HexNumber);
            this.Operands = operands;
        }

        Instruction(int opcode)
        {
            string hexop = this.Opcode.ToString("X");
            this.Opcode = int.Parse(hexop, System.Globalization.NumberStyles.HexNumber);
            this.Operands = null;
        }

        Instruction()
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
        public int getOpcode()
        {
            return this.Opcode;
        }

        public string[] getOperands()
        {
            return this.Operands;
        }

        public void PrintInstruction()
        {
            string currentdir = System.Environment.CurrentDirectory + "/";
            System.IO.StreamWriter writer = new System.IO.StreamWriter(currentdir + "instruction.asm", true);
            writer.Write(" ");
            if (this.Operands.Length != 0)
            {
                writer.Write(this.Opcode);
                for (int i = 0; i < this.Operands.Length; i++)
                {
                    writer.Write(this.Operands[i]);
                    writer.Write(",");
                }
                writer.WriteLine();
            }
            else
            {
                writer.Write(this.Opcode);
                writer.WriteLine();
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
            return;
        }
    }
}
