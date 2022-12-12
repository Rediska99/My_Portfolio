//33)Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

using System;

namespace zadacha32
{
    class Program
    {
        static void Main(string [] args)
        {
            int n=0, a=0, b=0;
            int[]arr=null;
            Console.WriteLine("Введите n-размер массива arr(n>1): ");
            n=int.Parse(Console.ReadLine());
            while(n<2)
                Console.WriteLine("Ошибка");
            Console.WriteLine("Введите а(a<n): ");
            a=int.Parse(Console.ReadLine());
            while(a<=0 || a>=n)
                Console.WriteLine("Ошибка");
            Console.Write($"Введите b(b>a и b<=n): ");
            b=int.Parse(Console.ReadLine());
            while(b<=a || b>n)
            Console.WriteLine($"Ошибка");    
            arr=new int[n];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(!((i + 1 > a) && (i + 1 < b)));
            Console.WriteLine(String.Join(", ", arr));  
        }
    }
}