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
            this.Opcode = opcode;
            this.Operands = operands;
        }

        Instruction(int opcode)
        {
            this.Opcode = opcode;
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
    }
}
