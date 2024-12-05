namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class PrimeOrLargestFactor
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine() ?? "");
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"Largest factor: {LargestFactor(number)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static int LargestFactor(int number)
        {
            for (int i = number / 2; i >= 1; i--)
            {
                if (number % i == 0) return i;
            }

            return 1;
        }
    }
}