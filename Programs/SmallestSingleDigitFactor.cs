namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class SmallestSingleDigitFactor
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine() ?? "");
                for (int i = 1; i <= 9; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"Smallest single digit factor: {i}");
                        return;
                    }
                }

                Console.WriteLine("No single digit factor found.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}