using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            int total = 3;
            Person[] persons = new Person[total];
            for (int i = 0; i <total; i++)
            {

                if (i==0)
                {
                    persons[i] = new Teacher("mellime");
                }
                else if (i == 1)
                {
                    persons[i] = new Student("telebe1");
                }
                else
                {
                    persons[i] = new Student("telebe2");
                }
            }
            ((Teacher)persons[0]).explain();
            ((Student)persons[1]).study();
            ((Student)persons[2]).study();

        }
    }
    public class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }
    }
    public class Student : Person
    {
        public Student(string name):base(name)
        {
            
        }
        public void study()
        {
            Console.WriteLine("studing...");
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }
        public void explain()
        {
            Console.WriteLine("explaining....");
        }
    }
}
