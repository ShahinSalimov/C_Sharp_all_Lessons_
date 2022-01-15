using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cari həyat günlərini hesablayan C# yazın (doğulduğunuzdan neçə gün keçib)
            Console.WriteLine("zehmet olmazsa dogum tarixinizi qey ederdiniz :");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            DateTime nd = DateTime.Now.Date;
            TimeSpan range =nd-dt;
            Console.WriteLine($"doguldugunuz tarixden {range} gun kecib...");
            Console.ReadKey();
        }
    }
}
