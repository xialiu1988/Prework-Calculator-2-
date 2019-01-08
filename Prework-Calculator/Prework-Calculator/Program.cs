using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double b = double.Parse(Console.ReadLine());
            //choose what operation you want
            Console.WriteLine("What you want to do? Add:press 1; Substract: press 2; Multiply: press 3; Divide: Press 4.");
            int c = Int32.Parse(Console.ReadLine());
            if (c == 1) { Add(a, b); }
            else if (c == 2) { Subtract(a, b); }
            else if (c == 3) { Multiply(a, b); }
            else { Divide(a, b); }
        }
        //sum
        public static void Add(double a, double b)
        {

            Console.WriteLine($"The sum is:{a + b}");


        }

        //substraction
        public static void Subtract(double a, double b)
        {

            Console.WriteLine($"The result of subtraction is:{a - b}");


        }
        //production
        public static void Multiply(double a, double b)
        {

            Console.WriteLine($"The production is:{a * b}");

        }

        //division
        public static void Divide(double a, double b)
        {
            double result = 0.0;

            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);

            }
            finally
            {
                Console.WriteLine($"The result is {result}");


            }
        }
    }
}
