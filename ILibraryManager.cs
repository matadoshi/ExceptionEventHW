using System;
using System.Collections.Generic;
using System.Text;

namespace EventHWTask
{
    internal interface ILibraryManager
    { 
        void AddBook(Book book);

        Book ShowInfo(string name);

        List<Book> Search(string value);

        List<Book> Filter(string author,string genre);
    }
    
}
