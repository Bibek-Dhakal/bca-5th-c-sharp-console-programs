namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class Magnitude
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine($"Magnitude: {Math.Abs(number)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}