using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double number = Input();
            result(number);
        }
        static double Input() {
            double localnumber;
            while (true)
            {
                Console.WriteLine("Введіть кількість спожитих кіловат-годин:");
                try
                {
                    localnumber = double.Parse(Console.ReadLine());
                    if (localnumber < 0)
                    {
                        Console.WriteLine("Число має бути невід'ємним.");
                        continue;
                    }
                    
                    return localnumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка! Введіть число.");
                }
            }
        }
        static void result(double number) {
            if (number <= 100)
            {
                Tariff(1.44, number);
                return;
            }
            else if (number >= 600)
            {
                Tariff(1.92, number);
                return;
            }
            else
            {
                Tariff(1.68, number);
                return;
            }
        }
        static void Tariff(double n, double number) {
            Console.WriteLine($"За тарифом {n} грн/кВт·год ціна складає: {number * n} грн");
        }
    }
}
