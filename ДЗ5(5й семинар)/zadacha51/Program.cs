//51)С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры.

using System;

namespace zadacha51
{
    class Program
    {
        static void Main(string[] args)
        {
            int N= int.Parse(Console.ReadLine());
            int [] a=new int[N];
            for(int i=0;i<a.Length;i++)
                a[i]=int.Parse(Console.ReadLine());

        }
       void PrintArray(int [] a)
        { 
            for(int i=0;i<a.Length;i++)
                Console.Write($"{a[i]}");     
        }   
        
        int Solve(int[]a)
        { 
            int count=0;
            for(int i=0;i<a.Length;i++)
                if(a[i]>0)
                    count++;
            return count;
        }
        
    }
}