//20)Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

using System;

namespace zadacha20
{
    class Program
    {
        static void Main(string [] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            if (X < 0 & Y > 0 )
            {
                Console.WriteLine("Первая четверть");
            }
            else
                if(X > 0 & Y > 0)
                {
                    Console.WriteLine("Вторая четверть");
                }
            else
                if(X < 0 & Y < 0)
                {
                    Console.WriteLine("Третья четверть");
                }    
            else
                if(X > 0 & Y < 0)
                {
                    Console.WriteLine("Четвертая четверть");
                }    
        }
    }
}
