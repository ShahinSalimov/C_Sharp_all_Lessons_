using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime cari = DateTime.Now;
            int yawim = cari.Year - 1987;
            int onilSonrakiyash = yawim + 10;
            Console.WriteLine(yawim);
            Console.WriteLine(onilSonrakiyash);

         Console.ReadKey();
        }
       
    }
}
