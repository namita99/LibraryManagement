using System;
using System.Collections.Generic;
using System.Text;

namespace cs_console_librarymanagement
{
    public class Newspaper1 : LibraryItem
    {
        public int NewspaperId { get; set; }
        public string NewspaperName { get; private set; }
        public int NewspaperPrice { get; private set; }


        public Newspaper1(
            int id, string name, int price, int count, int numCopies)
        {
            NewspaperId = id;
            NewspaperName = name;
            NewspaperPrice = price;
            base.bookCount = count;
            base.NumberOfCopies = numCopies;


        }

        public override string ToString()
        {
            return $"Newspaper Id: {this.NewspaperId}\n"
                   + $"Newspaper Name: {this.NewspaperName}\n"
                   + $"Newspaper price: {this.NewspaperPrice}\n"
                   + $"Number of counts: {base.bookCount}\n"
                   + $"Number of Copies: {base.NumberOfCopies}";
        }
    }
}
