using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Monopoly
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateBoard();
		}

        private static void CreateBoard()
        {
            Board theboard = new Board();
            Console.WriteLine("Board Created");
            Console.ReadKey();
        }
        


	}
}
