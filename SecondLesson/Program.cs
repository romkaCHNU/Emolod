using System;
using System.Text;

namespace SecondHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                double kilometers = Input("Введіть кількість кілометрів:");
                double waiting = Input("Введіть час простою (у хвилинах):");

                double result = kilometers * 10 + waiting * 2;

                if (result > 50)
                {
                    Console.WriteLine($"Вартість поїздки: {result:F2} грн");
                    return;
                }
                Console.WriteLine("Мінімальна вартість поїздки – 50 грн.\nВведіть дані заново:");
            }
        }

        static double Input(string message) {
            while (true)
            {
                Console.WriteLine(message);
                try
                {
                    double n = double.Parse(Console.ReadLine());
                    if (n >= 0)
                        return n;

                    Console.WriteLine("Число має бути невід'ємним. Спробуйте ще раз.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка! Введіть число.");
                }
            }
        }
    }
}
