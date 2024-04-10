using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Question1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Village by the sea"; // semicolon added here
            book.Author = "Arita Desai";

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);

            Console.ReadLine();
        }
    }

}
