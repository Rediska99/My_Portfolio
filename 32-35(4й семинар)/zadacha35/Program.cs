﻿//35)Написать программу замены элементов массива на противоположные


using System;
namespace ConsoleApplication2
{
  class Class
  {
    static int [] Input ()
    {
      Console.WriteLine("введите размерность массива");
      int n=int.Parse(Console.ReadLine());
      int []a=new int[n];
      for (int i = 0; i < n; ++i) 
      {
        Console.Write("a[{0}]= ", i);
        a[i]=int.Parse(Console.ReadLine());
      }
      return a;
    }
 
    static void Print(int[] a) 
    {
      for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
      Console.WriteLine();
    }
 
    static void Change(int[] a)
    {
      for (int i = 0; i < a.Length; ++i)
        if (a[i] > 0) a[i] = -a[i];
    }
 
    static void Main()
    {
      int[] myArray=Input();
Console.WriteLine("Исходный массив:");
      Print(myArray);
      Change(myArray);
Console.WriteLine("Измененный массив:");
      Print(myArray);
    }
  }
}