//56)Написать программу копирования массива
using System;
 
class Program
{
    static void Main()
    {
        int N= int.Parse(Console.ReadLine());
        int [] a=new int[N];
        for(int i=0;i<a.Length;i++)
            a[i]=int.Parse(Console.ReadLine());
 
        int[] copy = new int[a.Length];
        a.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(", ", copy));        
    }
}