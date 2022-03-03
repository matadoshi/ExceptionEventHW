using System;
using System.Collections.Generic;
using System.Text;

namespace EventHWTask
{
    internal class BookNotFound:Exception
    {
        public BookNotFound(string message) : base(message)
        {

        }
        public BookNotFound(string message, BookNotFound bookCustomException) : base(message, bookCustomException)
        {

        }

    }
}
