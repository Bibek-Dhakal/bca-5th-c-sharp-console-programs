using System;

namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    struct Book
    {
        public string Title;
        public string Author;
        public int Pages;

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
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