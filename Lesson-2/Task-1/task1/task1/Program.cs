using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program that takes three letters as input and display them in reverse order.
            //(Giriş kimi üç hərf qəbul edən C# proqramı yazın və onları tərs ardıcıllıqla göstərin.)
            Console.WriteLine("soz daxil edin:");
            char[] soz = Console.ReadLine().ToCharArray();
            Array.Reverse(soz);
            Console.WriteLine(soz);
            Console.ReadKey();
        }
    }
}
