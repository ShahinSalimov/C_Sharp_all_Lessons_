using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doğum gününüzün həftə gününü (məs: Bazar ertəsi) hesablayan C# yazın
            Console.WriteLine("zehmet olmazsa dogum tarixinizi qeyd edin:");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt.DayOfWeek);
            Console.ReadKey();
        }
    }
}
