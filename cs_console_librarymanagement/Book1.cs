using System;
using System.Collections.Generic;
using System.Text;

namespace cs_console_librarymanagement
{
    public class Book1 : LibraryItem
    {
       
        public int BookId { get; set; }

        public string BookName { get; private set; }
        public string BookAuthor { get; private set; }



        public Book1(int id, string title, string author, int numCopies, int price, int count)
        {
            BookId = id;
            BookName = title;
            BookAuthor = author;
            base.NumberOfCopies = numCopies;
            base.bookPrice = price;
            base.bookCount = count;


        }

        public override string ToString()
        {
            return $"Book ID: {this.BookId}\n"
                 + $"Book Name: {this.BookName}\n"
                + $"Book Author Name: {this.BookAuthor}\n"
                + $"Number of Copies: {base.NumberOfCopies}\n"
                + $"Book Price: {base.bookPrice}\n"
                + $"Book Count: {base.bookCount}";
        }
    }
}
