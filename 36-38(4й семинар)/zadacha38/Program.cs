//38)В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

using System;

namespace zadacha38
{
    class Program
    {
        static void Main(string []args)
        {
            int N=5;
            int [] a=new int[N];
            Random random=new Random();
            for(int i=0;i<a.Length;i++)
                a[i]=random.Next(0,300);
            for(int i=0;i<a.Length;i++)
                Console.WriteLine($"{a[i],5}");
            int count=0;
            for(int i=0;i<a.Length;i++)
                if(a[i]>=10 && a[i]<=99)
                    count++;
            Console.WriteLine();
            Console.WriteLine(count);                 
        }
    }
}