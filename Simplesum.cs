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

<<<<<<< HEAD
            Console.WriteLine($"Adding {num1} * {num2} equals {AddNumbers(num1, num2)} ");
=======
            Console.WriteLine($"Adding {num1} - {num2} equals {SustractNumbers(num1, num2)} ");
>>>>>>> 64598086969b648e211536a7196af8f714848971
        }

        public static int SustractNumbers(int num1, int num2)
        {

<<<<<<< HEAD
            return num1 * num2;
=======
            return num1 - num2;
>>>>>>> 64598086969b648e211536a7196af8f714848971
        }
    }
}