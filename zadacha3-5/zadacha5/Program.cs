using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Введите три числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a > b & a > c)
                Console.WriteLine("Число a больше");
            else
                if(a < c & b < c)
                    Console.WriteLine("Число c больше");
            else
                if(a < b & b > c)
                    Console.WriteLine("Число b больше");            
        }
    }
}