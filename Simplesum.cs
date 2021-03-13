using System;

namespace Example1
{
    internal class Program1
    {
        public static void Main(string[] args)
        {

            int num1 = 0, num2= 0;

            Console.WriteLine("Enter a integer value for Num1: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a integer value for Num2: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {num1} * {num2} equals {AddNumbers(num1, num2)} ");
        }

        public static int AddNumbers(int num1, int num2)
        {

            return num1 * num2;
        }
    }
}