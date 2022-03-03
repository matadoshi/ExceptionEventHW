using System;
using System.Collections.Generic;
using System.Text;

namespace EventHWTask
{
    class Library: ILibraryManager
    {
        private List<Book> _books;

        public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }
        public void AddBook(Book book)
        { 
            Book book1 = _books.Find(b => b.Name == book.Name);

            if (_books.Count == 0 || book1==null)
            {
                _books.Add(book);

            }
            else
            {
                throw new BookAlreadyExits("Bu Adda Kitab Artig Movcuddur", new BookAlreadyExits("Test"));
            }

        }
        public List<Book> Filter(string author, string genre)
        {
            return _books.FindAll(b => b.Author.ToLower().Contains(author.ToLower()) &&
                                       b.Genre.ToLower().Contains(genre.ToLower()));
        }

        public List<Book> Search(string value)
        {
            return _books.FindAll(b => b.Name.ToLower().Contains(value.ToLower())
                                || b.Author.ToLower().Contains(value.ToLower())
                                || b.Genre.ToLower().Contains(value.ToLower())
                                || b.PageCount.ToString().Contains(value.ToLower()));


        }

        public Book ShowInfo(string name)
        {

            return _books.Find(b => b.Name.ToLower() == name.ToLower()) ??
                throw new BookNotFound("Bu adda kitab tapilmadi.", new BookNotFound("Seciminizi Duzgun edin"));
        }

     
    }
}
