//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

using System;

namespace zadacha3
{
    class Program
    {
        static void Main()
        {
            int a,b;
            Console.WriteLine("Введите первое число:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = int.Parse(Console.ReadLine());
            if(a > b)
                Console.WriteLine("Число a больше.");
            else
                Console.WriteLine("Число b больше.");
        }
    }
}