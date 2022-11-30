//26)Найти сумму чисел от 1 до А

using System;

namespace zadacha24
{
    class Program
    {
        static void Main(string [] args)
        {
           int N = int.Parse(Console.ReadLine());
           int sum = 0;
           for(int i = 1; i <= N; i++)
               sum += i;
           Console.WriteLine("Сумма чисел:" + sum);
        }  
    }
}
