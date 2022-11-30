//31)Показать кубы чисел, заканчивающихся на четную цифру

using System;

namespace zadacha31
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a % 2 == 0)
                Console.WriteLine($"{a} ^ {3} = {Math.Pow(a , 3)}");
            else
                Console.WriteLine("Ошибка");    
        }
    }
}