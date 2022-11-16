//15.С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
using System;

namespace zadacha15
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a >= 100 & a <= 999)
                Console.WriteLine("Остаток:" + a % 10);
            else
            {
                if(a >= 1000)
                {
                    a = a / 10;
                    {
                        Console.WriteLine("статок:" + a % 10);
                    }
                }
                  
            }
            if(a >= 0 & a <= 99)
                Console.WriteLine("Числа нет");
        }
    }
}
