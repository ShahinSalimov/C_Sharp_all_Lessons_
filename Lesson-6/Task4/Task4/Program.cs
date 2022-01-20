using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin ayrı-ayrı rəqəmlərinin cəmini hesablamaq üçün
            //funksiya yaratmaq üçün C# dilində proqram yazın.
           
            Console.WriteLine(sum(3));
            Console.ReadKey();
        }

        static int sum(int num)
        {
            int sum = 0;
            for (int i = 1; i <=num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
