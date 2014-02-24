
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcDll
{
    class Parcel : Calculator
    {
        public static double CalculatePrice(double Length , double Width , double Depth , double Weight , double price)
        {
            Console.WriteLine("Enter Parcel Length");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Parcel Width");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Parcel Depth");
            Depth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Parcel Weight");
            Weight = Convert.ToDouble(Console.ReadLine());

            if (Length <= 16.0 || Width <= 16.0 || Depth <= 6.0 || Weight <= 2000)
            {
                price = 3.69;
            }
            else if (Length > 16.0 && Length <= 32.0 || Width > 16.0 && Width <= 32.0 || Depth > 6.0 && Depth <= 12.0 || Weight > 2000 && Weight <= 5000)
            {
                price = 4.99;
            }
            else if (Length > 32.0 || Width > 32.0 || Depth > 12.0 || Weight > 5000)
            {
                price = 7.99;
            }

            Console.WriteLine(Convert.ToString(price));

            return price;
        }
    }
}
