using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MainMenu");
            Console.WriteLine("1, Addition");
            Console.WriteLine("2, Subtract");
            Console.WriteLine("3, Multiply");
            Console.WriteLine("4, Divide");

            Console.WriteLine("Choose an operation");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine("The result is: " + result);
        }
    }
}
