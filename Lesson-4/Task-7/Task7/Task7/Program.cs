using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üç ədədin ən böyüyünü tapmaq üçün C# Sharp proqramını yazın.
            Console.WriteLine("num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("num3:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1>num2 && num2>num3)
            {
                Console.WriteLine($"{num1} ededi en boyuk ededdir.");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"{num2} ededi en boyuk ededdir.");
            }
            else
            {
                Console.WriteLine($"{num3} ededi en boyuk ededdir.");
            }
            Console.ReadKey();
        }
    }
}
