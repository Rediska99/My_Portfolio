//22)Программа проверяет пятизначное число на палиндромом.

using System;

namespace Project;

    class Program
    {
        static void Main(string[] args)
        {
           
            
            {
                int number = 52651;
                if(number > 9999 && number < 100000)
                {
                    int digitOne = number % 10;
                    int digitTen = number / 10 % 10;
                    int digitThousend = number / 1000 % 10;
                    int digitTenThousend = number / 10000;
                    if(digitOne == digitTenThousend && digitTen == digitThousend)
                    {
                        Console.WriteLine("Число полиндром");
                    } 
                    else
                    {
                        Console.WriteLine("Число не полиндром");
                    }

                }   
                else
                {
                    Console.WriteLine("Введено не пятизначное число");
                } 
            }
                
              

        }    
    }    
