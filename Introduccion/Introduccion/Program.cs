using System;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Person maria = new Person("Maria", 24, "Mexicana");

            Console.WriteLine(maria.Show());

            Console.ReadKey();
        }
    }

    class Person
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
}
