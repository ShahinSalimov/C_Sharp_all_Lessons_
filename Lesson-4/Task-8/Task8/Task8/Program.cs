using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //İstənilən gün sayını tam ədədlə oxumaq
            //və günün adını sözdə göstərmək üçün C# Sharp dilində proqram yazın.
            //Test Məlumatı : 4 Gözlənilən Nəticə : Cümə axşamı

            DateTime dd = DateTime.Now;
            Console.WriteLine(dd.DayOfWeek.ToString());
            Console.WriteLine(((int)dd.DayOfWeek));
            Console.ReadKey();


        }
    }
}
