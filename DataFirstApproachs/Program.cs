using System;
using System.Collections.Generic;
using System.Linq;
using DataFirstApproachs.Models;
namespace DataFirstApproachs
{
    class Program
    {
        PubsContext context;
        public Program()
        {
            context = new PubsContext();
        }
        List<Author> AuthorIdByName(string firstName,string lastName)
        {
            List<Author> authors = context.Authors
                .Where(a => a.AuLname == lastName && a.AuFname == firstName)
                .ToList();
            return authors;
            //return authors[0].AuId;

            
        }
        List<Titleauthor> FetechTitleIdsOfAuthor(string authorId)
        {
            List<Titleauthor> titleAuthors = context.Titleauthors
                .Where(a => a.AuId == authorId )
                .ToList();

            return titleAuthors;
        }
        void printTitleIdOfAuthor(List<Titleauthor> titleIdsOfAuthor)
        {
            foreach (var item in titleIdsOfAuthor)
            {
                Console.WriteLine("title id: "+item.TitleId);
            }

        }
        void PrintSalesDetailsOfTitle(string userTitleId)
        {
            List<Sale> salesDetails = context.Sales
                .Where(a => a.TitleId == userTitleId)
                .ToList();
            if (salesDetails.Count==0)
            {
                Console.WriteLine("No Sales with title "+ userTitleId);
                return;
            }
            Console.WriteLine("Sales details of "+userTitleId);
            foreach (var item in salesDetails)
            {
                Console.WriteLine("store Id : "+item.StorId);
                Console.WriteLine("order Number : "+item.OrdNum);
                Console.WriteLine("Order Date : "+item.OrdDate);
                Console.WriteLine(" Qty : "+item.Qty);
                Console.WriteLine("Payterms : "+item.Payterms);
                Console.WriteLine("----------------------");
            }

        }
        public void FetechAuthorDetailsByName()
        {
            string authorFirstName, authorLastName,  titileIds,userTitleId;
            List<Author> authorId = new List<Author>();
            List<Titleauthor> titleIdofAuthorl = new List<Titleauthor>();
            while (true)
            {
                Console.WriteLine("Please enter author first name");
                authorFirstName = Console.ReadLine();
                Console.WriteLine("Please enter author last name");
                authorLastName = Console.ReadLine();

                authorId = AuthorIdByName(authorFirstName, authorLastName);
                if (authorId.Count == 0)
                {
                    Console.WriteLine("Author yet to start");
                    continue;
                }
                else
                {
                    titleIdofAuthorl = FetechTitleIdsOfAuthor(authorId[0].AuId);
                    break;
                }
                
            }
            

            printTitleIdOfAuthor(titleIdofAuthorl);

            Console.WriteLine("Enter title Id");
            userTitleId = Console.ReadLine();
            PrintSalesDetailsOfTitle(userTitleId);
        }
       
        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                program.FetechAuthorDetailsByName();
                Console.WriteLine("do you want continue press 's' otherwise enter any other key");
                string userChoice = Console.ReadLine();
                if (userChoice == "s")
                    continue;
                else
                    break;

            }
                
             
            
            Console.WriteLine("Hello World!");
        }
    }
}
