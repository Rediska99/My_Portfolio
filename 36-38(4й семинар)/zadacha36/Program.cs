using System;

namespace zadacha36
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string[] array = { "Коля", "Федя", "Фрося", "Мотя" };
            name=Console.ReadLine();
            foreach (string str in array)
            {
                if (str == name)
                    Console.WriteLine(string.Format("Слово '{0}' содержится в массиве", name));
            }
        }
    }
}        
