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
            //İstifadəçidən 2 int nömrə girişi alın və dəqiq giriş1 / giriş2 hesablayın .
            //Nümunə: 16, 5. Nəticə 3 yox, 3,2 olmalıdır.
            Console.WriteLine("num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
           double result=num1 / num2;
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
