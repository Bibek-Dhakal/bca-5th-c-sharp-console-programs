using BCA_5th_Sem_lab_work_console_programs.Programs;

namespace BCA_5th_Sem_lab_work_console_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to execute:");
            Console.WriteLine("1. Find the smallest single digit factor");
            Console.WriteLine("2. Check if a number is prime or display its largest factor");
            Console.WriteLine("3. Find the magnitude of a number");
            Console.WriteLine("4. Matrix addition and multiplication");
            Console.WriteLine("5. Display digits of an integer in words");
            Console.WriteLine("6. Find the string with the most vowels");
            Console.WriteLine("7. Structures and Enumerations");
            Console.WriteLine("8. Constructors and Inheritance");
            Console.WriteLine("9. Polymorphism");
            Console.WriteLine("10. Partial Classes and Extension Methods");
            Console.WriteLine("11. Delegates");

            int choice = int.Parse(Console.ReadLine() ?? "");

            switch (choice)
            {
                case 1:
                    SmallestSingleDigitFactor.Execute();
                    break;
                case 2:
                    PrimeOrLargestFactor.Execute();
                    break;
                case 3:
                    Magnitude.Execute();
                    break;
                case 4:
                    MatrixOperations.Execute();
                    break;
                case 5:
                    DigitsInWords.Execute();
                    break;
                case 6:
                    StringWithMostVowels.Execute();
                    break;
                case 7:
                    StructuresAndEnumerations.Execute();
                    break;
                case 8:
                    ConstructorsAndInheritance.Execute();
                    break;
                case 9:
                    Programs.Polymorphism.Main.Execute();
                    break;
                case 10:
                    PartialClassesAndExtensionMethods.Execute();
                    break;
                case 11:
                    Delegates.Execute();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}