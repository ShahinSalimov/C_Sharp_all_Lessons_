using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Giriş kimi iki ədəd götürən və hər iki ədəd cüt və ya tək olduqda doğru
            //və ya yalanı qaytaran C# proqramı yazın.
            Console.WriteLine("num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2:");
            int num2 = int.Parse(Console.ReadLine());
            bool isOkay =num1 % 2 == 0;
            bool isOkay2= num2 % 2 == 0;
            bool test = isOkay == isOkay2;
            Console.WriteLine(test);
            Console.ReadKey();
          
        }
    }
}
