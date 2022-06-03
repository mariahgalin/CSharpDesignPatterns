using System;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            var maria = new SportyPerson("Maria", 24, "Mexicana");

            Console.WriteLine(maria.Show());
            maria.Run();

            Console.ReadKey();
        }
    }

    abstract class Person
    {
        public string name;
        public int age;
        public string nationality;
        public Person(string name_, int age_, string nationality_)
        {
            name = name_;
            age = age_;
            nationality = nationality_;
        }

        public string Show()
        {
            return name + " " + age + " " + nationality;
        }
    }

    class SportyPerson : Person 
    {
        public SportyPerson(string name_, int age_, string nationality_) : base(name_, age_, nationality_)
        {
           
        }

        public void Run()
        {
            Console.WriteLine( name + " is running");
        }
    }
}
