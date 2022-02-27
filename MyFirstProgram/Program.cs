using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            // inherited method (i.e the parent method) must be abstract with no body ha
            // virtual, or already overriden
            // used with ToString, polymorphism


            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
            
            Console.Beep();
            Console.ReadKey();
        }

    }


    class Animal
    {
        // indicate this method can be overriden
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woffff*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meooowww*");
        }
    }


}