using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance and Method Overriding Demo");

            Animal generic = new Animal();
            generic.MakeSound();   // Some generic sound

            Animal dog = new Dog();
            dog.MakeSound();       // Bark

            Animal cat = new Cat();
            cat.MakeSound();       // Meow
        }
    }
}
