using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //stifadəçi adından və soyadından müvafiq olaraq 2 giriş alan C# proqramı yazın
            //və sonra onu konsolda "NAME SOYADI" (hər ikisi böyük hərf) kimi çap edin.
            Console.WriteLine("ad:");
            string ad = Console.ReadLine().ToUpper();
            Console.WriteLine("Soyad:");
            string soyad = Console.ReadLine().ToUpper();
            Console.WriteLine(ad+" "+soyad);
            Console.ReadKey();
        }
    }
}
