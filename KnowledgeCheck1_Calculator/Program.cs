using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Calculator.PerformAddition(calculator);
                    break;
                case "2":
                    Calculator.PerformSubtraction(calculator);
                    break;
                case "3":
                    Calculator.PerformMultiplication(calculator);
                    break;
                case "4":
                    Calculator.PerformDivision(calculator);
                    break;
                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}