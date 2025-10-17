using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ2

{
    internal class Program
    {
        static void Main(string[] args) //КТ2
        {
            Book b = new Book();
            b.Title = "Преступление и наказание";
            b.Pages = 500;
            b.PrintInfo();
            Console.ReadKey();
        }

        public class Book
        {
            public string Title;
            private int _pages;

            public int Pages
            {
                get { return _pages; }
                set { if (value >= 0) _pages = value; }

            }
            public void PrintInfo()
            {
                Console.WriteLine($"Книга: {Title}, страниц: {Pages}");
            }

        }
    }
}
