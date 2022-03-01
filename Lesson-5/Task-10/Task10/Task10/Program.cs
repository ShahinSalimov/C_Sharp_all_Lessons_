using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ədədin palindrom ( vizual simmetrik ) olub olmadığını yoxlamaq üçün C# dilində proqram yazın .
            string c=string.Empty;
            Console.WriteLine("num:");
            c=Console.ReadLine();
            char[] arr=c.ToCharArray();
            Array.Reverse(arr);
            string b=new string(arr);
            if (c.Equals(b))
            {
                Console.WriteLine("polindromdur");
            }
            else
            {
                Console.WriteLine("poli deyil");
            }
        }
    }
}
