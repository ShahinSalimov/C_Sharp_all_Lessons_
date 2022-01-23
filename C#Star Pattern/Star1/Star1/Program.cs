using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int f = 0; f <=i; f++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
