using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ədədin iki sadə ədədin cəmi kimi ifadə oluna biləcəyini yoxlamaq üçün C# dilində proqram yazın.
            Console.WriteLine("num:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                for (int j = 1; j <=num; j++)
                {
                    if (i + j == num)
                    {
                        Console.WriteLine($"{i}+{j}={i + j}");
                    }
                }
            }
        }
    }
}
