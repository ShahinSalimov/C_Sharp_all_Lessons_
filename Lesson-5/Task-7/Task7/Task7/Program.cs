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
            //[ 9 + 99 + 999 + 9999 ...] seriyalarının cəmini göstərmək üçün C# dilində proqram yazın.

            Console.WriteLine("bir eded daxil edin:");
            int num = int.Parse(Console.ReadLine());
            int a = 9;
            int sum = 0;
            for (int i = 1; i <=num; i++)
            {
               
                Console.Write(a);
                Console.Write("{0} ", a);
                sum += a;
                a = (a * 10) + 9;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
