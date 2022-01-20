using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             10 və 100 arasında dəyəri daxil edin. 
            İstifadəçinin daxil etdiyi dəyərin uzunluğu ilə 
            təsadüfi qiymətlərlə int massivini işə salın. 
            Aşağıdakı tapşırıqları yerinə yetirin

            1.C# sort massivində həm azalan , həm də artan qaydada proqram yazın
            2.Massivin 3-cü maksimum elementini tapmaq üçün C# proqramı yazın.
            3.İlk 4 maksimum elementi tapmaq üçün C# dilində proqram yazın.*/

            Console.WriteLine("zehmet olmazsa 10-100 arasi bir reqem daxil edin :");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Random rn = new Random();
            for (int i=0; i<num;i++)
            {
                arr[i] = rn.Next(1,101);
                Console.WriteLine($"x[{i}]={arr[i]}");
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("azdan coxa dogru..");
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
