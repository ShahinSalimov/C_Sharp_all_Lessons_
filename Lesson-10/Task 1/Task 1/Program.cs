using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Greet("Nazim","Ahmedov");
            Student student = new Student();
            student.GoToClasses(21);
            student.Greet("Efsane","Melikova");
            student.ShowAge(25);
            Teacher teacher = new Teacher();
            teacher.GoToClasses(35);
            teacher.Greet("Sekine", "Ehmedova");
            teacher.Explain("Azerbaycan Tarixi");

        }
    }
    public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public int Age { get; set; }
        public string CurrentClass { get; set; }    
        public void Greet(string name,string surname)
        {
            Name = name;
            Surname = surname;  
            Console.WriteLine($"Hello {name} {surname}");
        }
        public void GoToClasses(int age)
        {
            Age = age;
            try
            {
                if (age>=6 || age<=50)
                {
                    Console.WriteLine("yashiniz uygundur,siz mektebe getmelisiniz!!!");
                }
            }
            catch (Exception exx)
            {

                Console.WriteLine("sizin yawiniz uygun deyil");
            }
        }

    }
    public class Student : SchoolPerson
    {
        public new void GoToClasses(int age)
        {
            Age = age;
            try
            {
                if (age >= 6 || age <= 50)
                {
                    Console.WriteLine("Men telebeyem ve derse gedirem");
                }
            }
            catch (Exception exx)
            {

                Console.WriteLine("sizin yawiniz uygun deyil");
            }
        }
        public void ShowAge(int age)
        {
            Age=age;
            Console.WriteLine($"menim {age} yawim var..");
        }
    }
    public class Teacher : SchoolPerson
    {
        public string Subject { get; set; } 
        public void Explain(string subject)
        {
            Subject = subject;
            Console.WriteLine($"Explanation begin on subject {subject}");
        }
        public void GoToClasses(string name,string surname)
        {
            Name=name;
            Surname=surname;
            Console.WriteLine($"men: {name} {surname},mellimem");
        }
    }
}
