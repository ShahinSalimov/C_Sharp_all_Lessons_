using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klaviaturadan 5 ədədi oxumaq və onların cəmini və ortasını tapmaq üçün C# dilində proqram yazın.
            Console.WriteLine("num1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num3 :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num4 :");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num5 :");
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"daxil edilen edelerin cemi {num1+num2+num3+num4+num5}");
            Console.WriteLine($"daxil edilen edelerin ortasi {(num1 + num2 + num3 + num4 + num5)/5}");
            Console.ReadKey();


        }
    }
}
