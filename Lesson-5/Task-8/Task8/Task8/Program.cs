using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ədədin palindrom ( vizual simmetrik ) olub olmadığını yoxlamaq üçün C# dilində proqram yazın .
            string num = Console.ReadLine();
            char[] arr = num.ToCharArray();
            
                if (arr[0] == arr[arr.Length-1])
                {
                    Console.WriteLine($"{num} polindrom ededdir..");
                }
                else
                {
                    Console.WriteLine($"{num} polindrom eded deyil..");
                }
            

            Console.ReadKey();
        }

    }
}
