using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_hackerrank_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a time in -hour AM/PM format, convert it to military (24-hour) time.
            Console.WriteLine(timeConversion("00,01,00"));
            Console.ReadKey();
        }
        public static string timeConversion(string s)
        {
            string v = DateTime.ParseExact(s, CultureInfo.CurrentCulture).ToString("hh:mm tt");
            return v;
        }
    }
}
