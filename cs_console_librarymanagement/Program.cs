using System;
using System.Collections.Generic;

namespace cs_console_librarymanagement
{

    //Defining a class Book
    class Book
    {
        public int bookId;
        public string bookName;
        public string bookAuthor;
        public int bookPrice;
        public int bookCount;
        public int x;
    }

    //Defining a class Newspaper
    class Newspaper
    {
        public int paperId;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int y;
    }

    class BorrowDetails1
    {
        public int userID;
        public string userName;
        public string userAddress;
        public int borrowPaperId;
        public DateTime borrowDate;
        public int borrowCount;
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

        static List<Newspaper> newsList = new List<Newspaper>();
        static List<BorrowDetails1> borrowList1 = new List<BorrowDetails1>();
        static Newspaper news = new Newspaper();
        static BorrowDetails1 borrow1 = new BorrowDetails1();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library!!");
            Console.WriteLine("*****************************");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Borrower");
            Console.WriteLine(" Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            // Use a switch statement to do the math.  
            if (ch == 1)
            {
                Console.WriteLine("\nMenu\n" +
                    "1. Books\n" +
                    "2. Newspapers\n");

            }
            else if (ch == 2)
            {
                Console.WriteLine("\nMenu\n" +
                                    "1. Borrow\n" +
                                    "2. Return\n");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            int user = int.Parse(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Welcome to the library Librarian!!");
                bool clos = true;
                while (clos)
                {

                    Console.WriteLine("\nMenu\n" +
                "1)Add book\n" +
                "2)Delete book\n" +
                "3)Search book\n" +
                "4)Borrow book\n" +
                "5)Return book\n" +
                "6)Close\n\n");
                    Console.Write("Choose your option from menu :");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            GetBook();
                            break;
                        case 2:
                            RemoveBook();
                            break;
                        case 3:
                            SearchBook();
                            break;
                        case 4:
                            Borrow();
                            break;
                        case 5:
                            ReturnBook();
                            break;

                        case 6:
                            {
                                Console.WriteLine("Thank you");
                                clos = false;
                                break;
                            }
                    }
                }
            }
            else if (user == 2)
            {
                Console.WriteLine("Welcome to the library Librarian!!");
                bool close1 = true;
                while (close1)
                {
                    Console.WriteLine("\nMenu\n" +
                    "1)Add Newspaper\n" +
                    "2)Delete Newspaper\n" +
                    "3)Search Newspaper \n" +
                    "4)Borrow Newspaper\n" +
                    "5)Return Newspaper\n" +
                    "6)Close\n\n");
                    Console.Write("Choose your option from menu :");

                    int option1 = int.Parse(Console.ReadLine());

                    switch (option1)
                    {
                        case 1:
                            GetNewspaper();
                            break;
                        case 2:
                            RemoveNewspaper();
                            break;
                        case 3:
                            SearchNewspaper();
                            break;
                        case 4:
                            Borrow1();
                            break;
                        case 5:
                            ReturnNewspaper();
                            break;

                        case 6:
                            {
                                Console.WriteLine("Thank you");
                                close1 = false;
                                break;
                            }
                    }
                }
            }
            Console.ReadLine();
        }

        //To add book details to the Library database
        static void GetBook()
                {
                    Book book = new Book();

                    {
                        Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
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
                }

                //To delete book details from the Library database 
                static void RemoveBook()
                {
                    Book book = new Book();


                    Console.Write("Enter Book id to be deleted : ");

                    int Del = int.Parse(Console.ReadLine());

                    if (bookList.Exists(x => x.bookId == Del))
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

                    if (bookList.Exists(x => x.bookId == find))
                    {
                        foreach (Book searchId in bookList)
                        {
                            if (searchId.bookId == find)
                            {
                                Console.WriteLine("Book id :{0}\n" +
                                "Book Name :{1}\n" +
                                "Book Author name: {2}\n" +
                                "Book price :{3}\n" +
                                "Book Count :{4}", searchId.bookId, searchId.bookName, searchId.bookAuthor, searchId.bookPrice, searchId.bookCount);
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

                    if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
                    {
                        foreach (Book searchId in bookList)
                        {
                            if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                            {
                                if (searchId.bookId == borrow.borrowBookId)
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

                    if (bookList.Exists(y => y.bookId == returnId))
                    {
                        foreach (Book addReturnBookCount in bookList)
                        {
                            if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                            {
                                if (addReturnBookCount.bookId == returnId)
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
        public static void GetNewspaper()
        {
            Newspaper paper = new Newspaper();

            {
                Console.WriteLine("Newspaper Id:{0}", paper.paperId = newsList.Count + 1);
                Console.Write("Newspaper Name:");
                paper.paperName = Console.ReadLine();

                Console.Write("Newspaper Price:");
                paper.paperPrice = int.Parse(Console.ReadLine());
                Console.Write("Number of Newspaper:");
                paper.y = paper.paperCount = int.Parse(Console.ReadLine());
                newsList.Add(paper);
            }
        }
        public static void RemoveNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Enter Newspaper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (newsList.Exists(x => x.paperId == Del))
            {
                newsList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            newsList.Add(news);
        }

        //To search book details from the Library database using Book id 
        public static void SearchNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Search by Newspaper id :");
            int find = int.Parse(Console.ReadLine());

            if (newsList.Exists(x => x.paperId == find))
            {
                foreach (Newspaper searchId in newsList)
                {
                    if (searchId.paperId == find)
                    {
                        Console.WriteLine("Newspaper id :{0}\n" +
                        "Newspaper Name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.paperId, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        public static void Borrow1()
        {
            Newspaper paper = new Newspaper();
            BorrowDetails1 borrow1 = new BorrowDetails1();
            Console.WriteLine("User id : {0}", (borrow1.userID = borrowList.Count + 1));
            Console.Write("Name :");

            borrow1.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow1.borrowPaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Papers: ");
            borrow1.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow1.userAddress = Console.ReadLine();
            borrow1.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow1.borrowDate.ToShortDateString(), borrow1.borrowDate.ToShortTimeString());

            if (newsList.Exists(x => x.paperId == borrow1.borrowPaperId))
            {
                foreach (Newspaper searchId in newsList)
                {
                    if (searchId.paperCount >= searchId.paperCount - borrow1.borrowCount && searchId.paperCount - borrow1.borrowCount >= 0)
                    {
                        if (searchId.paperId == borrow1.borrowPaperId)
                        {
                            searchId.paperCount = searchId.paperCount - borrow1.borrowCount;
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
                Console.WriteLine("Book id {0} not found", borrow1.borrowPaperId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        public static void ReturnNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.WriteLine("Enter following details :");

            Console.Write("Newspaperid : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Newspaper:");
            int returnCount = int.Parse(Console.ReadLine());

            if (newsList.Exists(y => y.paperId == returnId))
            {
                foreach (Newspaper addReturnBookCount in newsList)
                {
                    if (addReturnBookCount.y >= returnCount + addReturnBookCount.paperCount)
                    {
                        if (addReturnBookCount.paperId == returnId)
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
                Console.WriteLine("Newspaper id {0} not found", returnId);
            }
        }

    }
 }
    

                
                          

                            
   

