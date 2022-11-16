//12.С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
using System;

namespace zadacha12
{
    class Program
    {
        static void Main(string [] args)
        {
            int a;
            do
            {
              Console.WriteLine("Введите число [10;99]:");  
              a = int.Parse(Console.ReadLine());
            }     
            while(a < 10 || a > 99);
            int d1 = a / 10;
            int d2 = a % 10;
            int max;
            if (d1 > d2) max = d1; else max = d2;
            Console.WriteLine($"Max digit is {max}");  
        }
    }
}
