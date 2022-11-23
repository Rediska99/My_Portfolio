//18)По двум заданным числам проверять является ли одно квадратом другого.

using System;

namespace zadacha18
{
    class Program
    {
        static void Main(string [] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           if(b == a * a )
           {
            Console.WriteLine("b является квадратом a");
           }
           else
                if(a == b * b )
           {
            Console.WriteLine("a является квадратом b");
           }
           else
           {
            Console.WriteLine("Ошибка ввода");
           }
        }
    }
}
