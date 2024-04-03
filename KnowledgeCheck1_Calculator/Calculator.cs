using System;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {                               //basic calculator properties
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }

                                    //methods to perform the calculations
        public static void PerformAddition(Calculator calculator)
        {
            Console.WriteLine("Enter 2 integers to add");
            var addNumber1 = Console.ReadLine();
            var addNumber2 = Console.ReadLine();

            if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
            {
                Console.Write($"{addNumber1} + {addNumber2} = ");
                Console.Write(calculator.Add(addNumOne, addNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        public static void PerformSubtraction(Calculator calculator)
        {
            Console.WriteLine("Enter 2 integers to subtract");
            var subtractNumber1 = Console.ReadLine();
            var subtractNumber2 = Console.ReadLine();

            if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
            {
                Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                Console.Write(calculator.Subtract(subNumOne, subNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        public static void PerformMultiplication(Calculator calculator)
        {
            Console.WriteLine("Enter 2 integers to multiply");
            var multiplyNumber1 = Console.ReadLine();
            var multiplyNumber2 = Console.ReadLine();
            if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
            {
                Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                Console.Write(calculator.Multiply(multNumOne, multNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        public static void PerformDivision(Calculator calculator)
        {
            Console.WriteLine("Enter 2 integers to divide");
            var divideNumber1 = Console.ReadLine();
            var divideNumber2 = Console.ReadLine();

            if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
            {
                Console.Write($"{divideNumber1} / {divideNumber2} = ");
                Console.Write(calculator.Divide(divNumOne, divNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
