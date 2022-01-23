using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_hackerrrank_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.Write (" ");
                }
                for (int k = 0; k <=i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
