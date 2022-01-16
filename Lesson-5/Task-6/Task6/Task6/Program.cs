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
            //Write a program in C# to make such a pattern like
            //right angle triangle with number increased by 1.
            int a = 1;
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(a++);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
