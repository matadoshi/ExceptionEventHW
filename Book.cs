using System;
using System.Collections.Generic;
using System.Text;

namespace EventHWTask
{
    class Book
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public int PageCount { get; set; }

        public string Genre { get; set; }

        public Book(string name,string author,int pagecount,string genre)
        { 
            Name = name;
            Author = author;
            PageCount = pagecount;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Name:{Name} Author:{Author} Genre:{Genre} PageCount:{PageCount}";
        }
    }
}
