namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    delegate void GreetDelegate(string name);

    public static class Delegates
    {
        public static void Execute()
        {
            GreetDelegate greet = Greet;
            greet("Alice");

            greet = Farewell;
            greet("Bob");
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Farewell(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }
    }
}