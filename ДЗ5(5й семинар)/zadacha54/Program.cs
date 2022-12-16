//54)С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
using System;
 
class Program
{
    static void Main()
    {
        int N= int.Parse(Console.ReadLine());
        int [] a=new int[N];
        for(int i=0;i<a.Length;i++)
            a[i]=int.Parse(Console.ReadLine());
        int b=Array.FindIndex(a,i=>i==0);
        int c=Array.FindIndex(a,i=>i==1);
        Console.WriteLine("Ноль: "+b);
        Console.WriteLine("Единица: "+c);
                
    }
}
