using System;
using System.Collections.Generic;

namespace EventHWTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Kitab","Kitab Muellifi",100,"Kitabin Janri");
            Book book1 = new Book("Junior","Kitab Mauellifi",400,"Kitaabin Janri");
            Book book2 = new Book("Harry Potter","Thomas Shelby",300,"Criminal");
            Book book3 = new Book("Junior","Kitab Muellifi", 400, "Kitabin Janri");

            Library library = new Library();    
            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);


            foreach (var item in library.Filter("Thomas Shelby", "Criminal"))
            {
                Console.WriteLine(item);
            }
            foreach (var item in library.Search("Kitab Muellifi"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(library.ShowInfo("Junior"));


        }
    }
}
