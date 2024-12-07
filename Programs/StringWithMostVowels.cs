namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class StringWithMostVowels
    {
        public static void Execute()
        {
            int rows = 2;
            int columns = 2;
            string[,] strings = new string[rows, columns];
            Console.WriteLine("Enter strings for a 2D array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter string for position [{i},{j}]: ");
                    strings[i, j] = Console.ReadLine() ?? "";
                }
            }

            string stringWithMostVowels = "";
            int maxVowelCount = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int currentVowelCount = CountVowels(strings[i, j]);
                    if (currentVowelCount > maxVowelCount)
                    {
                        maxVowelCount = currentVowelCount;
                        stringWithMostVowels = strings[i, j];
                    }
                }
            }

            Console.WriteLine(
                $"\nString with the most vowels: \"{stringWithMostVowels}\" with {maxVowelCount} vowels.");
        }

        static int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}