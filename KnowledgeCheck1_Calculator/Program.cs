using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    };

    public class Program
    {
        static void Main(string[] args)
        {
            // I do not like the original menu.

            Console.WriteLine("Hello! Select your math operation!");
            Console.WriteLine("1.Addition\n\r" +
                              "2.Subtraction\n\r" +
                              "3.Multiplication\n\r" +
                              "4.Division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    {
                        ProcessSelection(calculator, Operation.Add);
                        break;
                    }
                case "2":
                    {
                        ProcessSelection(calculator, Operation.Subtract);
                        break;
                    }
                case "3":
                    {
                        ProcessSelection(calculator, Operation.Multiply);
                        break;
                    }
                case "4":
                    {
                        ProcessSelection(calculator, Operation.Divide);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown Selection");
                        break;
                    }
            }
        }

        private static void ProcessSelection( Calculator calc, Operation operand )
        {
            Console.Write("Please enter your first number: ");
            var number1 = Console.ReadLine();

            Console.Write("Please enter your second number: ");
            var number2 = Console.ReadLine();

            if( double.TryParse(number1, out double numberOne) && double.TryParse(number2, out double numberTwo))
            {
                switch (operand)
                {
                    case Operation.Add:
                    {
                        Console.Write($"{numberOne} + {numberTwo} = ");
                        Console.Write(calc.Add(numberOne, numberTwo));
                        break;
                    }
                    case Operation.Subtract:
                    {
                        Console.Write($"{numberOne} - {numberTwo} = ");
                        Console.Write(calc.Subtract(numberOne, numberTwo));
                        break;
                    }
                    case Operation.Multiply:
                    {
                        Console.Write($"{numberOne} * {numberTwo} = ");
                        Console.Write(calc.Multiply(numberOne, numberTwo));
                        break;
                    }
                    case Operation.Divide:
                    {
                        Console.Write($"{numberOne} / {numberTwo} = ");
                        Console.Write(calc.Divide(numberOne, numberTwo));
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Unknown Selection");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("One or more numbers are not of valid input.");
            }
        }
    }
}