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
            //İstifadəçidən 2 sətir girişi alan və ikinci sətir birinci sətirdə olarsa,
            //onu qaytaran C# proqramı yazın. Misal. 1-ci giriş: Azərbaycan, 2-ci giriş:
            //çünki Nəticə doğru ola bilər bilər olan Azərbaycan
            Console.WriteLine("first string :");
            string str1 = Console.ReadLine().ToLower();
            Console.WriteLine("second string :");
            string str2 = Console.ReadLine().ToLower();
            bool test = str1.Contains(str2);
            Console.WriteLine(test);
            Console.ReadKey();

        }
    }
}
