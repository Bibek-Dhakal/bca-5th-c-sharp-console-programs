namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public partial class Person
    {
        public required string FirstName { get; set; }
    }

    public partial class Person
    {
        public required string LastName { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    public static class PersonExtensions
    {
        public static void Greet(this Person person)
        {
            Console.WriteLine($"Hello, {person.FirstName}!");
        }
    }

    public static class PartialClassesAndExtensionMethods
    {
        public static void Execute()
        {
            Person person = new Person { FirstName = "John", LastName = "Doe" };
            person.Display();
            person.Greet();
        }
    }
}