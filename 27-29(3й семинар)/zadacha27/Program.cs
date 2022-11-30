//27)Возведите число А в натуральную степень B используя цикл

using System;

namespace zadacha27
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(b >= 0 || b <= 0)
                Console.WriteLine($"{a} ^ {b} = {Math.Pow(a , b)}");
        }
    }
}