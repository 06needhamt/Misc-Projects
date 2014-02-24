    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CalcDll;

    namespace CalcDll
    {
    public class Calculator
    {
        public static void Run()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("Hello");
            Console.WriteLine("Enter 1 for add");
            Console.WriteLine("Enter 2 for Subtract");
            Console.WriteLine("Enter 3 for multiply");
            Console.WriteLine("Enter 4 for divide");
            // Console.WriteLine("Enter 5 for parcel Calculator");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Calculator.Add(0, 0, 0);
                    Calculator.Reset(false);
                    break;
                case 2:
                    Calculator.Subtract(0, 0, 0);
                    Calculator.Reset(false);
                    break;
                case 3:
                    Calculator.Multiply(0, 0, 0);
                    Calculator.Reset(false);
                    break;
                case 4:
                    Calculator.Divide(0, 0, 0);
                    Calculator.Reset(false);
                    break;
                default:
                    Environment.Exit(0);
                    break;

            }
        }
        public static double Add(double a , double b , double total)
        {
            Console.WriteLine("Enter First Number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToDouble(Console.ReadLine());
            total = a + b;
            Console.WriteLine(Convert.ToString(total));
            return total;
        }

        public static double Subtract(double a, double b, double total)
        {
            Console.WriteLine("Enter First Number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToDouble(Console.ReadLine());
            total = a - b;
            Console.WriteLine(Convert.ToString(total));
            return total;
        }

        public static double Multiply(double a, double b, double total)
        {
            Console.WriteLine("Enter First Number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToDouble(Console.ReadLine());
            total = a * b;
            Console.WriteLine(Convert.ToString(total));
            return total;
        }

        public static int Divide(int a, int b, int total)
        {
            try
            {

                Console.WriteLine("Enter First Number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                b = Convert.ToInt32(Console.ReadLine());
                total = a / b;
                Console.WriteLine(Convert.ToString(total));
                return total;
            }
            catch (Exception ex)
            {
                ex = null;
                ex = new DivisionByZeroException();
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
            
        public static bool Reset(bool another)
        {
            another = false;
            Console.WriteLine("Do You Want to perform another calculation");
            Console.WriteLine("Enter 0 for no");
            Console.WriteLine("Enter 1 for yes");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    another = false;
                    break;
                case 1:
                    another = true;
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            if (another == true)
            {
                Calculator.Run();
            }
            else
            {
                Environment.Exit(0);
            }
            return another;
        }
    }
    }
