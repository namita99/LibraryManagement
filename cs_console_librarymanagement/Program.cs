using System;
using System.Collections.Generic;

namespace cs_console_librarymanagement
{
    //Defining a class Book
    class Book
    {
        public int bookID;
        public string bookName;
        public string bookAuthor;
        public Boolean IsBorrowed;
        public int bookPrice;
        public int bookCount;
        public int x;
    }
    //Defining a class for newspaper
    class Newspaper
    {
        public int paperID;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int y;
    }
    //Defining a class Borrow
    class BorrowDetails
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();
        static List<Newspaper> paperList = new List<Newspaper>();


        static void Main(string[] args)
        {
        again:
            Console.Write("===========Welcome to the Library!!==========\n" +
                "Please select the user type:  \n 1) Librarian \n 2)Borrower\n ");
            int user = int.Parse(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Welcome to the library Librarian!!\n");
                Console.WriteLine("What Do you want to acces: \n" +
                    "1) Books\n" +
                    "2) Newspapers\n");
                int user1 = int.Parse(Console.ReadLine());
                if (user1 == 1)
                {
                    bool clos = true;
                    while (clos)
                    {
                        Console.WriteLine("\nMenu\n" +
                        "1)Add book\n" +
                         "2)Delete book\n" +
                         "3)Search book\n" +
                         "4)Display book\n" +
                         "5)Close\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                AddBook();
                                break;
                            case 2:
                                RemoveBook();
                                break;
                            case 3:
                                SearchBook();
                                break;
                            case 4:
                                DisplayBooks();
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Thank you");
                                    Console.WriteLine(clos);
                                    clos = false;
                                    Console.WriteLine(clos);
                                    Console.WriteLine("Accessing Newspaper method");
                                    GetNewspaper();
                                    GetNewspaper1();
                                    Borrow();

                                    break;
                                }
                        }


                    }
                }
                else if (user1 == 2)
                {
                    Console.WriteLine("Welcome to the library Librarian!!");
                    Console.WriteLine("Accessing Newspaper method");
                    GetNewspaper();
                }

                Console.ReadLine();
            }

            else if (user == 2)
            {

                Console.WriteLine("Welcome to the Library :: Reader!!");
                Console.WriteLine("What Do you want to acces: \n" +
               "1) Books\n" +
               "2) Newspapers\n");
                int user1 = int.Parse(Console.ReadLine());
                if (user1 == 1)
                {

                    bool clos = true;
                    while (clos)
                    {

                        Console.WriteLine("\nMenu\n" +
                    "1) Borrow a book\n" +
                    "2) Return a book\n" +
                    "3) Display a book\n" +
                    "4) Close\n\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                BorrowBook();
                                break;
                            case 2:
                                ReturnBook();
                                break;
                            case 3:
                                DisplayBooks();
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Thank you");
                                    Console.WriteLine(clos);
                                    clos = false;
                                    Console.WriteLine(clos);
                                    Console.WriteLine("Accessing Newspaper method");
                                    GetNewspaper1();
                                    break;
                                }
                        }

                    }



                }

                else if (user1 == 2)
                {
                    Console.WriteLine("Welcome to the library Librarian!!");
                    Console.WriteLine("Accessing Newspaper method");
                    GetNewspaper1();

                }
            }
            else
            {
                Console.WriteLine("Invalid Input\n" +
                    "If You want to continue Press Y to or else press any key");
                string c = Console.ReadLine();
                if (c == "y" || c == "Y")
                    goto again;
            }

        }

        static void GetNewspaper()
        {

            bool clos1 = true;
            while (clos1)
            {


                Console.WriteLine("\nMenu\n" +
                  "1)Add Paper\n" +
                  "2)Delete Paper\n" +
                  "3)Search Paper\n" +
                  "4)Display Paper\n" +
                  "5) Close\n");
                Console.Write("Choose your option from menu :");

                int option1 = int.Parse(Console.ReadLine());

                switch (option1)
                {
                    case 1:
                        AddNewspaper();
                        break;
                    case 2:
                        RemoveNewspaper();
                        break;
                    case 3:
                        SearchNewspaper();
                        break;
                    case 4:
                        DisplayNewspaper();
                        break;

                    case 5:
                        {
                            Console.WriteLine("Thank you");
                            Console.WriteLine(clos1);
                            clos1 = false;
                            Console.WriteLine(clos1);
                            Console.WriteLine("Accessing Books method");
                            GetNewspaper1();
                            break;
                        }
                }
            }
        }
        static void GetNewspaper1()
        {
            bool clos = true;
            while (clos)
            {
                Console.WriteLine("\nMenu\n" +
                "1) Borrow a Newspaper\n" +
                "2) Return a Newspaper\n" +
                "3) Display a Newspaper\n" +
                "4) Close\n\n");
                Console.Write("Choose your option from menu :");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Borrow1();
                        //BorrowNewspaper();
                        break;
                    case 2:
                        ReturnNewspaper();
                        break;
                    case 3:
                        DisplayNewspaper();
                        break;

                    case 4:
                        {
                            Console.WriteLine("Thank you");
                            clos = false;
                            break;
                        }

                }
            }
        }

        private static void BorrowBook()
        {
            Book1 bk1 = new Book1(
                1, "Nature", "Mr. Aggarwal", 50, 1000, 30);


            Borrowable item1 = new Borrowable(bk1);
            Console.WriteLine(item1);
            Console.WriteLine();

            item1.BorrowItem("user1");
            item1.BorrowItem("user2");


            Console.WriteLine(item1);
            Console.WriteLine();

        }

        private static void BorrowNewspaper()
        {
            Newspaper1 np1 = new Newspaper1(
               1, "Lokmat", 10, 5, 100);


            Borrowable item1 = new Borrowable(np1);
            Console.WriteLine(item1);
            Console.WriteLine();

            item1.BorrowItem("user1");
            item1.BorrowItem("user2");


            Console.WriteLine(item1);
            Console.WriteLine();

        }
        private static void DisplayBooks()
        {
            Book1 bk1 = new Book1(
               1, "Nature", "Mr. Aggarwal", 50, 1000, 30);
            Console.WriteLine(bk1);
            Console.WriteLine();

            Book1 bk2 = new Book1(
                 2, "Game of Thrones", "Mr. Khan", 100, 2000, 20);
            Console.WriteLine(bk2);
            Console.WriteLine();

            Book1 bk3 = new Book1(
                3, "Wings of Fire", "Mr. Karnad", 500, 5000, 10);
            Console.WriteLine(bk3);
            Console.WriteLine();
        }

        private static void DisplayNewspaper()
        {
            Newspaper1 np1 = new Newspaper1(
               1, "Lokmat", 10, 5, 100);
            Console.WriteLine(np1);
            Console.WriteLine();

            Newspaper1 np2 = new Newspaper1(
                  1, "Prabhat", 15, 10, 150);
            Console.WriteLine(np2);
            Console.WriteLine();

            Newspaper1 np3 = new Newspaper1(
                 1, "Sakhal", 8, 15, 200);
            Console.WriteLine(np3);
            Console.WriteLine();
        }
        //To add book details to the Library database


        static void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookID = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Author Name:");
            book.bookAuthor = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        //To delete book details from the Library database 
        static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookID == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }

        //To search book details from the Library database using Book id 
        static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookID == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookID == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookID, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        static void Borrow()
        {

            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookID == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookID == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookID == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookID == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

        //Adding a newspaper to library
        static void AddNewspaper()
        {
            Newspaper paper = new Newspaper();

            {
                Console.WriteLine("Newspaper Id:{0}", paper.paperID = paperList.Count + 1);
                Console.Write("Newspaper Name:");
                paper.paperName = Console.ReadLine();

                Console.Write("Newspaper Price:");
                paper.paperPrice = int.Parse(Console.ReadLine());
                Console.Write("Number of Newspaper:");
                paper.y = paper.paperCount = int.Parse(Console.ReadLine());
                paperList.Add(paper);
                Console.WriteLine("Newspapers added Successfully.");
            }
        }

        //Deleting paper from the library

        static void RemoveNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Enter Newspaper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == Del))
            {
                paperList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            paperList.Add(paper);
        }

        //To search paper details from the Library database using Paper id 

        static void SearchNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Search by Newspaper id :");
            int find = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == find))
            {
                foreach (Newspaper searchId in paperList)
                {
                    if (searchId.paperID == find)
                    {
                        Console.WriteLine("Newspaper id :{0}\n" +
                        "Newspaper Name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.paperID, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", find);
            }
        }

        static void Borrow1()
        {
            Newspaper paper = new Newspaper();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (paperList.Exists(x => x.paperID == borrow.borrowBookId))
            {
                foreach (Newspaper searchId in paperList)
                {
                    if (searchId.paperCount >= searchId.paperCount - borrow.borrowCount && searchId.paperCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.paperID == borrow.borrowBookId)
                        {
                            searchId.paperCount = searchId.paperCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} Newspaper are found", searchId.paperCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Paper id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }
        //To return borrowed book to the library 
        static void ReturnNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.WriteLine("Enter following details :");

            Console.Write("Newspaper id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Newspaper:");
            int returnCount = int.Parse(Console.ReadLine());

            if (paperList.Exists(a => a.paperID == returnId))
            {
                foreach (Newspaper addReturnBookCount in paperList)
                {
                    if (addReturnBookCount.y >= returnCount + addReturnBookCount.paperCount)
                    {
                        if (addReturnBookCount.paperID == returnId)
                        {
                            addReturnBookCount.paperCount = addReturnBookCount.paperCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }


    }

}




