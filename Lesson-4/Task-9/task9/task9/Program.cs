using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
            Console.WriteLine("num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("caculator ucun seciminizi edin : toplama(1),cixma(2),vurma(3),bolme(4)");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine($"cavab :{num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"cavab :{num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"cavab :{num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"cavab :{num1 / num2}");
                    break;
            }
            Console.ReadKey();

        }
    }
}
