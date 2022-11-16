//14.С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
using System;

namespace zadacha12
{
    class Program
    {
        static void Main(string [] args)
        {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         if(a % b == 0)
            Console.WriteLine("Без остатка:" + a / b);
         else
            Console.WriteLine("Остаток:" + a % b);   
        }
    }
}
