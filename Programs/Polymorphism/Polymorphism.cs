using System;

namespace BCA_5th_Sem_lab_work_console_programs.Programs.Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    public static class Main
    {
        public static void Execute()
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Speak();
            myCat.Speak();
        }
    }
}