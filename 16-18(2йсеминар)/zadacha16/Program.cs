//16)Дано число. Проверить кратно ли оно 7 и 23

using System;

namespace zadacha18
{
    class Program
    {
        static void Main(string [] args)
        {
           int a = int.Parse(Console.ReadLine());
           if(a % 7 ==0)
           {
            Console.WriteLine("a кратно 7");
           }
           else
                if(a % 23 ==0)
           {
            Console.WriteLine("a кратно 23");
           }
           else
           {
            Console.WriteLine("Ошибка ввода");
           }
        }
    }
}

