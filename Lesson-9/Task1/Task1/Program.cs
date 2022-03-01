using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İstifadəçidən üç nəfərin adını tələb edən və onları Person tipli
            //obyektlər massivində saxlayan C# proqramı yaradın.
            //Bunu etmək üçün əvvəlcə Name tipli xassə olan Person sinfi yaradın
            //stringvə ToString() metodunu ləğv edin.

            //İnsanları oxumaqla və ekranda ToString() metodunu icra etməklə proqramı bitirin.
            Console.WriteLine("name1:");
            string name1=Console.ReadLine();
            Console.WriteLine("name2:");
            string name2 = Console.ReadLine();
            Console.WriteLine("name3:");
            string name3 = Console.ReadLine();
           
            Person a = new Person(name1);
            Person b = new Person(name2);
            Person c = new Person(name3);
            Person[] person;
            person = new Person[] { a, b, c };
            Console.WriteLine(person[0].getName(person[0].Name));
            Console.WriteLine(person[1].getName(person[1].Name));
            Console.WriteLine(person[2].getName(person[2].Name));



        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public string getName(string name)
        {
            Name = name;
            string printname = $"Salam ! Menim adim {name}-dir.";
            return printname;
        }
    }


}
