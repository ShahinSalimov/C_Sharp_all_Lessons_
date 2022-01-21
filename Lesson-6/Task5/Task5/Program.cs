using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin ayrı-ayrı rəqəmlərinin cəmini hesablamaq
            //üçün funksiya yaratmaq üçün C# dilində proqram yazın. 
            //Rəqəm daxil edin: 1234 Gözlənilən Nəticə : 1234 rəqəminin rəqəmlərinin cəmi : 10-dur
            Console.WriteLine("number:");
            char[] arr = Console.ReadLine().ToCharArray();
            Console.WriteLine(FindSumNumber(arr));
            Console.ReadKey();
        }


        static int FindSumNumber(char[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {

                string b = Convert.ToString(item);
                int c = Convert.ToInt32(b);
                sum += c;
            }
            return sum;
        }
    }
}
