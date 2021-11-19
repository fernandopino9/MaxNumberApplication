using System;

namespace MaxNumberApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            double num3 = double.Parse(Console.ReadLine());

           
            Console.WriteLine(Math.Max(Math.Max(num1, num2), num3));


        }
    }
}
