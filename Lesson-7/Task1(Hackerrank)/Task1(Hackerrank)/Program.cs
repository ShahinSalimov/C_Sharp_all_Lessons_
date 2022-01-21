using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Hackerrank_
{
    class Program
    {
        static void Main(string[] args)
        {//Beş müsbət tam ədəd verilmişdir,
            //beş tam ədəddən dördünü cəmləməklə hesablana bilən
            //minimum və maksimum dəyərləri tapın. 
            //Numune :arr=[1,2,3,4,5]
            //min sum: 1+2+3+4=10
            //max sum :2+3+4+5=14
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            FindMinAndMaxSum(arr);
            Console.ReadKey();
        }
        static void FindMinAndMaxSum(int[] arr)
        {
            long sum = 0;
            int min = arr.Min();
            int max = arr.Max();
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"elementlerin en kicik cemi :{sum - max}\n elementlerin en boyuk cemi :{sum - min}");
        }
    }
}
