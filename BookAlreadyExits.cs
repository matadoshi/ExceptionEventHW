using System;
using System.Collections.Generic;
using System.Text;

namespace EventHWTask
{
    class BookAlreadyExits:Exception
    {
        public BookAlreadyExits(string message):base(message)
        {

        }
        public BookAlreadyExits(string message, BookAlreadyExits bookCustomException) : base(message, bookCustomException)
        {

        }

    }
}
