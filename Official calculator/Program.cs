using System;

namespace Official_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator<double>();

            Console.WriteLine("Welcome to my calculator!");

            Console.WriteLine("Please put first number: ");
            var firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please put second number: ");
            var secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please put which operation would you like to make.");
            Console.WriteLine("You can choose one of these: + - * /");

            var operation = Console.ReadLine();

            var result = default(double);

            switch (operation)
            {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secondNumber);
                    } break;
                case "-":
                    {
                        result = calculator.Subtract(firstNumber, secondNumber);
                    } break;
                case "*":
                    {
                        result = calculator.Multiply(firstNumber, secondNumber);
                    } break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("You can't divide by ZERO!");
                    }
                    else
                    {
                        result = calculator.Divide(firstNumber, secondNumber);
                    } break;
                default:
                    {
                        Console.WriteLine("Wrong action! Start again!");
                    }
                    break;


            }
            Console.WriteLine("Result of your operation is: " + result);
            Console.WriteLine("Press any key to close the window.");
        }
    }
}
