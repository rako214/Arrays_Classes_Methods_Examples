using System;

namespace Classes
{
    class Person
    {
        public string name;
        public int age;

        public Person() { name = "Неизвестно"; age = 18; }

        public Person(string n) { name = n; age = 18; }

        public Person(string n, int a) { name = n; age = a; }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            Person bob = new Person("Bob");
            Person sam = new Person("Sam", 25);

            sam.GetInfo();
            tom.GetInfo();
            bob.GetInfo();

        }
    }
}
