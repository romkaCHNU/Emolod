using System;
using System.Text;

namespace FirstHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                int operation = Choose();
                double firstNumber = 0, secondNumber = 0;

                if (operation == 5)
                {
                    Console.WriteLine("Введіть число:");
                    firstNumber = Input();
                }
                else
                {
                    StandartInput(ref firstNumber, ref secondNumber);
                }
                switch (operation)
                {
                    case 1:
                        Result(firstNumber + secondNumber);
                        return;
                    case 2:
                        Result(firstNumber - secondNumber);
                        return;
                    case 3:
                        Result(firstNumber * secondNumber);
                        return;
                    case 4:
                        if (secondNumber == 0)
                        {
                            Problem();
                            continue;
                        }
                        Result(firstNumber / secondNumber);
                        return;
                    case 5:
                        if (firstNumber < 0)
                        {
                            Problem();
                            continue;
                        }
                        Result(Math.Sqrt(firstNumber));
                        return;
                    case 6:
                        if (secondNumber < 0)
                        {
                            Problem();
                            continue;
                        }
                        Result(Math.Pow(firstNumber, secondNumber));
                        return;
                    default:
                        Problem();
                        continue;
                }

            }
        }

        static void StandartInput(ref double firstNumber, ref double secondNumber)
        {
            Console.WriteLine("Введіть перше число:");
            firstNumber = Input();
            Console.WriteLine("Введіть друге число:");
            secondNumber = Input();
        }
        
        static double Input()
        {

            while (true)
            {
                try
                {
                     return double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Problem();
                }
            }
        }

        static int Choose()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Виберіть дію:\n1 - додавання \n2 - віднімання\n3 - множення\n4 - ділення \n5 - корінь квадратний\n6 - піднесення до степеня");
                    string operate = Console.ReadLine();
                    if (int.Parse(operate) <= 6 && int.Parse(operate) >= 1)
                    {
                        return int.Parse(operate);
                    }
                    Problem();
                        return Choose();
                }
                catch (FormatException)
                {
                Problem();
                }
            }
        }

        static void Result(double n)
        {
            Console.WriteLine("Результат: " + n);
        }

        static void Problem()
        {
            Console.WriteLine("Помилка! Введіть число.");
        }
    }
}
