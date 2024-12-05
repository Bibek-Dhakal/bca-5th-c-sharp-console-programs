namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class StringWithMostVowels
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Enter the number of strings:");
                int n = int.Parse(Console.ReadLine() ?? "");
                string[] strings = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter string {i + 1}:");
                    strings[i] = Console.ReadLine() ?? "";
                }

                string stringWithMostVowels = FindStringWithMostVowels(strings);
                Console.WriteLine($"String with the most vowels: {stringWithMostVowels}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static string FindStringWithMostVowels(string[] strings)
        {
            int maxVowelCount = 0;
            string result = string.Empty;

            foreach (string str in strings)
            {
                int vowelCount = CountVowels(str);
                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                    result = str;
                }
            }

            return result;
        }

        private static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}