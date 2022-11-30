//30)Написать программу вычисления произведения чисел от 1 до N

using System;

namespace zadacha24
{
    class Program
    {
        static void Main(string [] args)
        {
           int N = int.Parse(Console.ReadLine());
           int k = 1;
           for(int i = 1; i <= N; i++)
               k *= i;
           Console.WriteLine("Произведение чисел:" + k);
        }  
    }
}
