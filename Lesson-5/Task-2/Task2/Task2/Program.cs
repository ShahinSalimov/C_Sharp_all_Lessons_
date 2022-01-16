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
            //İlk 20 tək natural ədədin cəmini tapmaq üçün C# proqramı yazın.
            int sum = 0;
            int[] arr=new int[20];
            for (int i = 0; i <=40; i++)
            {
                
                if (i%2==0)
                {
                    continue;
                    arr[i] = i;
                }
                if (arr.Length==19)
                {
                    sum += arr[i];
                }

                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
