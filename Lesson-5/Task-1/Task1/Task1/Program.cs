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
            //İlk 10 natural ədədi göstərmək üçün C# dilində proqram yazın

            for (int i = 1; i <=20; i++)
            {
                if (i==11)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
