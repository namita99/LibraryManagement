using System;
using System.Collections.Generic;

namespace cs_console_library
{
    
    //Defining a class Newspaper
    class Newspaper
    {
        public int paperId;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int y;
    }

    //Defining a class Borrow
    class BorrowDetails1
    {
        public int userID;
        public string userName;
        public string userAddress;
        public int borrowPaperId;
        public DateTime borrowDate;
        public int borrowCount;
    }
  


    class Program
    {
        static List<Newspaper> newsList = new List<Newspaper>();
        static List<BorrowDetails1> borrowList = new List<BorrowDetails1>();
        static Newspaper news = new Newspaper();
        static BorrowDetails1 borrow = new BorrowDetails1();

        //Password verfication and Menu 
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Library !!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "library")
            {
                bool close = true;
                while (close)
                {

                    Console.WriteLine("\nMenu\n" +
                    "1)Add Newspaper\n" +
                    "2)Delete Newspaper\n" +
                    "3)Search Newspaper \n" +
                    "4)Borrow Newspaper\n" +
                    "5)Return Newspaper\n" +
                    "6)Close\n\n");
                    Console.Write("Choose your option from menu :");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        GetNewspaper();
                    }
                    else if (option == 2)
                    {
                        RemoveNewspaper();
                    }
                    else if (option == 3)
                    {
                        SearchNewspaper();
                    }
                    else if (option == 4)
                    {
                        Borrow();
                    }
                    else if (option == 5)
                    {
                        ReturnNewspaper();
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
            Console.ReadLine();
        }

        //To add book details to the Library database
        public static void GetNewspaper()
        {
            Newspaper paper = new Newspaper();
            for (int i = 0; i <= 5; i++)
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

        //To delete book details from the Library database 
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
                        Console.WriteLine("Book id :{0}\n" +
                        "Book Name :{1}\n" +
                        "Book Author name: {2}\n" +
                        "Book price :{3}\n" +
                        "Book Count :{4}", searchId.paperId, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        public static void Borrow()
        {
            Newspaper paper = new Newspaper();
            BorrowDetails1 borrow = new BorrowDetails1();
            Console.WriteLine("User id : {0}", (borrow.userID = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow.borrowPaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Papers: ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (newsList.Exists(x => x.paperId == borrow.borrowPaperId))
            {
                foreach (Newspaper searchId in newsList)
                {
                    if (searchId.paperCount >= searchId.paperCount - borrow.borrowCount && searchId.paperCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.paperId == borrow.borrowPaperId)
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
                Console.WriteLine("Book id {0} not found", borrow.borrowPaperId);
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