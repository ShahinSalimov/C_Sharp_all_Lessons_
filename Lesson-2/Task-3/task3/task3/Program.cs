using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dairənin radiusunu daxil edən C# proqramı yazın və çevrənin perimetrini
            //və sahəsini hesablayın və onu konsolda çap edin.

            Console.WriteLine("zehmet olmazsa dairenin radiusunu daxil edin:");
            int radius = int.Parse(Console.ReadLine());
            double pi=3.14;
            double cevrenin_sahesi = pi * radius * radius;
            double cevrenin_perimetri = 2 * pi * radius;
            Console.WriteLine($"cevrenin perimetri {cevrenin_perimetri}-a beraberdir.\nCevrenin sahesi ise {cevrenin_sahesi}-a beraberdir.");
            Console.ReadKey();
        }
    }
}
