using System;
using System.Diagnostics.CodeAnalysis;

namespace EADAssi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string inp1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string inp2 = Console.ReadLine();

            // initializing the numbers with 0 so that we can use then in try block

            double num1=0, num2=0;

            try
            {
                num1 = double.Parse(inp1);
                num2 = double.Parse(inp2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                System.Environment.Exit(0);
            }

            Console.Write("Enter operator (+, -, *, /, %): ");
            char op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    break;
                case '%':
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

        }
    }
}
