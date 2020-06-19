using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal("Bob");

            Console.WriteLine(myAnimal.Name);

        }
    }

    class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void SetAnimalName(string name)
        {
            Name = name;
        }
    }

}



