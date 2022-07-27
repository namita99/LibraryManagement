using System;
using System.Collections.Generic;
using System.Text;

namespace cs_console_librarymanagement
{
    public abstract class LibraryItem
    {
        public int NumberOfCopies { get; set; }
        public int bookPrice { get; set; }

        public int bookCount { get; set; }


    }
}
