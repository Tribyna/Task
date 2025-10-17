using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    public class Book
    {
        public void DispalayInfo()
        {
            Console.WriteLine("test");
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("z", "z", 17);
            book.DispalayInfo();

        }
    }
}
