using System;

namespace zadacha8
{
    class Program
    {
        static void Main(string [] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = -N; i <= N; i++ )
             Console.Write(i);
            
        }
    }
}
