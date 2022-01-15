using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //daxil edilen tarixin son gununu cap eden c# programi yazin...
            Console.WriteLine("day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("year:");
            int year = int.Parse(Console.ReadLine());
            DateTime nd = DateTime.Now;
            Console.WriteLine("------------------------------");
            Console.WriteLine($"daxil edilen tarix {day+"/"+month+"/"+year}");
            Console.WriteLine("--------------------------------------------");
            var find =31-nd.Day;
            var lastDay = find + nd.Day;
            Console.WriteLine($"daxil edilen tarixin son gunu: {lastDay+"/"+month+"/"+year}");
            Console.ReadKey();
        }
    }
}
