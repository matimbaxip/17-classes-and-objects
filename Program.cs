using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_classes_and_objects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
    

        static void Main(string[] args)
        {
            Book book1 = new Book();// create a new book object
                                    // creation of a new book
            book1.title = "Harry Potter";
            book1.author = "JH Rowlin";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of rings";
            book2.author = "Tolein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title); 
            // Freeze
            Console.ReadLine();
        }
    }
}
