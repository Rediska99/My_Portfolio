//25)Вывести на экран кубы чисел от 1 до N

using System;

namespace zadacha24
{
    class Program
    {
        static void Main(string [] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            
                Console.WriteLine($"{i} ^ {3} = {Math.Pow(i , 3)}");
            
        }
    }
}
