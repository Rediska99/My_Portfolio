//28)Определить количество цифр в числе. Сделать подпрограмму.

using System;

namespace zadacha27
{
    class Program
    {
        static void Main(string [] args)
        {
          int a = int.Parse(Console.ReadLine());
          int i = 0;
          if(a >= 0 || a <= 0)
          {
            i++;
            a /= 10;
          }
          Console.WriteLine("Количество цифр в числе: " + i);
        }
    }
}