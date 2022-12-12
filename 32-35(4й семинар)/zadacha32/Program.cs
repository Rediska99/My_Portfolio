//32)Задать массив из 8 целых элементов и вывести их на экран

using System;

namespace zadacha32
{
    class Program
    {
        static void Main(string [] args)
        {
            int []a = {1,2,3,4,5,6,7,8};
            for(int i = 0; i <= a.Length; i++)
            Console.WriteLine(i);
        }
    }
}