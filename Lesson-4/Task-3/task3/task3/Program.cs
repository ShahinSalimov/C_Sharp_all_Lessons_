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
            //Bu andan 40 gün sonra həftənin hansı gününün olduğunu hesablamaq üçün C# proqramı yazın
            DateTime nd = DateTime.Now;
            
            
            Console.WriteLine($"cari tarixden 40gun sonra heftenin {nd.Add(TimeSpan.Parse("39.23:59:59")).DayOfWeek} gunudur....");
            Console.ReadKey();
        }
    }
}
