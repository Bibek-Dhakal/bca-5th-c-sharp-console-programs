namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    struct Book
    {
        private string _title;
        private string _author;
        private int _pages;

        public Book(string title, string author, int pages)
        {
            _title = title;
            _author = author;
            _pages = pages;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Pages: {_pages}");
        }
    }

    enum Genre
    {
        Fiction,
        NonFiction,
        Mystery,
        SciFi,
        Biography
    }

    public static class StructuresAndEnumerations
    {
        public static void Execute()
        {
            Book book = new Book("1984", "George Orwell", 328);
            book.Display();

            Genre genre = Genre.Fiction;
            Console.WriteLine($"Genre: {genre}");
        }
    }
}