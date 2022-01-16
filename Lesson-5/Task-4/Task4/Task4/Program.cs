using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vurma cədvəlini şaquli olaraq 1-dən n -ə qədər göstərmək üçün C# dilində proqram yazın .
            Console.WriteLine("vurma cedvelini istediyiniz sayda qeyd edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
               
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                  
                }
                
            }
           
            Console.ReadKey();
        }
    }
}
