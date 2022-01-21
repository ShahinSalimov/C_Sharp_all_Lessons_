using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //sətirdəki boşluqların sayını hesablamaq üçün C# Sharp dilində proqram yazın. 
            Console.WriteLine("cumle:");
            char [] soz = Console.ReadLine().ToCharArray();
            
            Console.WriteLine(FindTrim(soz));
            Console.ReadKey();
        }

        static int FindTrim(char[] a)
        {
            int count = 0;
            foreach (var item in a)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
