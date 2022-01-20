using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //n ədəd Fibonacci ardıcıllığını göstərmək üçün funksiya yaratmaq üçün C# dilində proqram yazın.
            Console.WriteLine("bir eded daxil edin:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }
            Console.ReadKey();
        }
        static int fibonacci(int num)
        {
            int firstNum = 0;
            int secondNum = 1;
            int Result = 0;
            if (num == 0) return 0; 
            if (num == 1) return 1;
            for (int i = 2; i <=num; i++)
            {
                Result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = Result;
            }
            return Result;
        }
    }
}
