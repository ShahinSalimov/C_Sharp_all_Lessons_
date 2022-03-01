using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.Study();
            Console.WriteLine(student.SetAge(25));
            student.Greet();
            Teacher teacher = new Teacher();
            Console.WriteLine(teacher.SetAge(45));
            teacher.Explain();  
            teacher.Greet();


        }
    }
    
    
    public class Person
    {
        public string Name { get; set; }
        public byte Age; 
        public void Greet()
        {
            Console.WriteLine("Salam aleykum");
        }
        public string SetAge(byte age)
        {
            Age = age;
            return $"My age is: {age} years old";
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public byte ShowAge(byte age)
        {
            Age = age;
            return age;
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
        
    }
}
