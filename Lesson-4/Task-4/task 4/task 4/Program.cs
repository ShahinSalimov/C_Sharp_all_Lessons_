using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilən ilin, ayın və günün cari olub-olmadığını yoxlamaq üçün C# dilində proqram yazın.
            Console.WriteLine("cari gunu daxil edin:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("cari ayi daxil edin:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("cari ili daxil edin:");
            int year = int.Parse(Console.ReadLine());
            DateTime nd = DateTime.Now;
            bool test = day == nd.Day && month == nd.Month && year == nd.Year;
            Console.WriteLine($"daxil etdiyiniz tarix {day+"/"+month+"/"+year}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Netice :");
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
