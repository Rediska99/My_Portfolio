//21)Задать номер четверти, показать диапазоны для возможных координат

using System;

namespace zadacha20
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
           
            if (a == 1)
            {
                Console.WriteLine("X < 0; Y > 0");
            }
            else
                if(a == 2)
                {
                    Console.WriteLine("X > 0; Y > 0");
                }
            else
                if(a == 3)
                {
                    Console.WriteLine("X < 0; Y < 0");
                }    
            else
                if(a == 4)
                {
                    Console.WriteLine("X > 0; Y < 0");
                }    
        }
    }
}

