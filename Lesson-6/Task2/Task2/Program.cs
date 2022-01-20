using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Əlavə dəyişən olmadan iki tam ədədin qiymətlərini dəyişdirmək
            //funksiyası yaratmaq üçün C# dilində proqram yazın.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            changeNum(num1,num2);
            Console.ReadKey();

        }

        static void changeNum(int num1,int num2)
        {
            num1 += num2;
            num2 = num1-num2;
            num1 -= num2;
            Console.WriteLine($"birinci ededin deyeri {num1}.");
            Console.WriteLine($"ikinci ededin deyeri {num2}.");

        }
    }
}
