namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class DigitsInWords
    {
        public static void Execute()
        {
            Console.WriteLine("Enter an integer:");
            try
            {
                int number = int.Parse(Console.ReadLine() ?? "");
                string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

                foreach (char digit in number.ToString())
                {
                    Console.Write(words[digit - '0'] + " ");
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}