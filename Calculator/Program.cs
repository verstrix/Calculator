using System;
using System.Transactions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If u want to perform a addition type 1");
            Console.WriteLine("If u want to perform a substraction type 2");
            Console.WriteLine("If u want to perform a multiply type 3");
            Console.WriteLine("If u want to perform a devide type 4");
            Console.WriteLine("Enter an option: ");
            var function = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter number 1");

            double number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter number 2");

            double number2 = int.Parse(Console.ReadLine());

            switch (function)
            {
                case 1:
                    Console.WriteLine(number1 + number2);             
                    break;
                case 2:
                    Console.WriteLine(number1 - number2);
                    break;
                case 3:
                    Console.WriteLine(number1 * number2);
                    break;
                case 4:
                    Console.WriteLine(number1 / number2);
                    break;
                default: Console.WriteLine("Type a valid option");
                    break;
            }
        }
    }
}
