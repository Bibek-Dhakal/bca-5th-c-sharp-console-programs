using System;

namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    public static class ConstructorsAndInheritance
    {
        public static void Execute()
        {
            Dog dog = new Dog("Buddy");
            dog.Speak();
            dog.Bark();
        }
    }
}