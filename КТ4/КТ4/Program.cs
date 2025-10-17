using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Hello", "World");
            book.DispalayInfo();

        }
    }
    public class Book
    {
        public void DispalayInfo()
        {
            Console.WriteLine($"{Title} {Author} {Year}");
            Console.ReadKey();
        }

        public Book()
        {


        }

        public Book(string Title, string Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }

        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = 2024;
        }

        public string Title;
        public string Author;
        public int Year;
    }
}
