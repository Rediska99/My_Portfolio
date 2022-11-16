//10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
using System;

namespace zadacha10
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Последняя цифра:" + a % 10);
        }
    }
}
