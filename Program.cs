using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение_по_определению_чётного_или_нечётного_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number;

            Console.WriteLine("Введите число: ");
            number = long.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            Console.ReadKey();
        }
    }
}
