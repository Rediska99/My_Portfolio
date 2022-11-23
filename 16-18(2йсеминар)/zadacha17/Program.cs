//17)Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using System;

namespace zadacha13
{

    class Program
    {
        static void Main(string [] args)
        {
            int day;
           Console.WriteLine("Введите число:");
           day=Convert.ToInt32(Console.ReadLine());
           if (day == 6 || day == 7)
           {
            Console.WriteLine("Выходной");
           }
           else if ( day >=1 && day <=5)
           {
            Console.WriteLine("Будни");
           }
           else
           {
            Console.WriteLine("Некорректный ввод");
           }
        }
    }
}    
