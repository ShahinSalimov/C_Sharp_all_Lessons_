using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_hackerrank_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir il verilir,y, həmin il ərzində rəsmi rus təqviminə görə həmin ilin
            //256-cı gününün tarixini tapın . Sonra onu formatda çap edin dd.mm.yyyy,
            //burada dd iki rəqəmli gün, mm iki rəqəmli aydır və yyyy belədir.
            // sıçrayış ilində 29 gün , digər illərdə isə 28 gün var. Julian təqvimində sıçrayış illəri 4-ə bölünür;
            // Qriqorian təqvimində sıçrayış illəri aşağıdakılardan biridir:
            //400-ə bölünür.
            //4 - ə bölünür və 100 - ə bölünmür.
            Console.WriteLine(dayOfProgrammer(2017));
            Console.ReadKey();
        }

        public static string dayOfProgrammer(int year)
        {
            int progDay = 256;
            string day;
            if (year%4==0 && year%400==0 && year%100!=0)
            {
                int sum = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                int Leapyear = progDay - sum;
                day = $"{Leapyear}:09:{year}";

            }
            else
            {
                int sum1 = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                int Leapyear = progDay - sum1;
                day = $"{Leapyear}:09:{year}";

            }
            return day;
        }
    }
}
