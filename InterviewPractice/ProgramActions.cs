﻿using Practice.AttributesReflection;
using Practice.Automapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Practice.Abstractions;
using Practice.Collections;
using Practice.Extentions;
using Practice.Interfaces.Articles;
using Practice.MultipleInheritance;
using Practice.OOP_Principles;

namespace Practice
{
    static class ProgramActions
    {
        public static void Perform_AttributesReflections()
        {
            IEnumerable<string> types = Assembly.GetExecutingAssembly().GetTypes()
                                                .Where(x => x.GetCustomAttributes<SampleAttribute>().Count() > 0)
                                                .Select(x => x.Name);

            foreach (var item in types)
            {
                Console.WriteLine(item);
            }
        }
        public static void Perform_Automapper()
        {
            MapperConfiguration config = new MapperConfiguration(c => { c.CreateMap<UserEntity, User>(); });
            IMapper mapper = config.CreateMapper();

            // Simulating the User get from Database
            UserEntity userRecord = new UserEntity()
            {
                Name = "Steve Jobs",
                Age = 23,
                Address = "Washington, D.C.",
                isActive = true,
                Password = "000"
            };

            // Create a new user and assign only needed properties
            User user = mapper.Map<UserEntity, User>(userRecord);

            Console.WriteLine(user.Name + "\n" + user.Address + "\n" + user.Age);
        }
        public static void Perform_Abstractions()
        {
            Supermarket sm = new Supermarket("Supermarket", "Chisinau");

            sm.SelledItems = new List<string>() { "Toys", "Clothes", "Foods" };
            Console.WriteLine("This " + sm.GetMarketType + " in " + sm.GetLocation + " sells:");
            foreach (var item in sm.SelledItems)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine(sm.MarketActivity());

            Console.WriteLine();

            AirMarket am = new AirMarket("AirMarket", "Straseni");
            am.SelledItems = new List<string>() { "Vegetables", "Fruits", "Unelts" };
            Console.WriteLine("This " + am.GetMarketType + " in " + am.GetLocation + " sells:");
            foreach (var item in am.SelledItems)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine(am.MarketActivity());
        }
        public static void Perform_Queue()
        {
            QueueCollection qc = new QueueCollection();

            Console.WriteLine("Initial filling...");
            qc.InitialFillQueue();

            Console.WriteLine("\n\tAll names in queue:");
            qc.WriteAllNames();

            Console.WriteLine("\nAdding name \"Martha\" (Enqueue)...");
            qc.AddItemInNames("Martha");

            Console.WriteLine("\n\tAll names in queue:");
            qc.WriteAllNames();

            Console.Write("\n\tThe oldest name (Peek): ");
            Console.WriteLine(qc.GetTheOldest());

            Console.WriteLine("\nRemove the oldest (Dequeue)...");
            qc.RemoveOldest();

            Console.WriteLine("\n\tAll names in queue:");
            qc.WriteAllNames();

            //// In case of non-generic Queue class
            //Console.WriteLine("\nAdding number 5...");
            //qc.AddItemInNames(5);

            //Console.WriteLine("\nAll names in queue:");
            //qc.WriteAllNames();
        }
        public static void Perform_Extension()
        {
            List<Transaction> transactions = new List<Transaction>()
            {
                new Transaction(100), new Transaction(0), new Transaction(-50)
            };

            int counter = 1;
            Console.WriteLine("Result:");
            foreach (var transaction in transactions)
            {
                if (transaction.TransactionPassed())
                {
                    Console.WriteLine("\t"+counter+") Transaction passed with value: " + transaction.Value + ".");
                }
                else
                {
                    Console.WriteLine("\t"+counter + ") " + transaction.GetTransactionError());
                    Console.WriteLine("\t   Transaction value: " + transaction.Value);
                }
                counter++;
            }
        }
        public static void Perform_Interfaces()
        {
            IArticle table = new TableArticle();
            IArticle chair = new ChairArticle();
            IArticle chair2 = new ChairArticle();

            string tname = table.Name;
            int tarticles = table.GetNumberOfArticles();

            string cname = chair.Name;
            int carticles = chair.GetNumberOfArticles();
            // chair.DoStuff() isn't available, because 
            // chair uses ChairArticle's implementation of IArticle.
            // It's about using interface implementation, not the class functionallity

            Console.WriteLine(tname +" : "+ tarticles);
            Console.WriteLine(cname +" : "+ carticles);
        }
        public static void Perform_MultipleInheritance()
        {
            //MollysBooks mb = new MollysBooks();
            //Console.WriteLine(mb.GetInformation());
            //Console.Write("You can get the price of a book that you seek for: ");
            //try
            //{
            //    Console.WriteLine(mb.GetPrice(Console.ReadLine()));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            GarrysPages gp = new GarrysPages();
            Console.WriteLine(gp.GetInformation());
            Console.Write("You can get the price of a book that you seek for: ");
            try
            {
                Console.WriteLine(gp.GetPrice(Console.ReadLine()));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Perform_Polymorphism()
        {
            Polymorphism poly = new Polymorphism();
            string result1 = poly.AddSome();
            int result2 = poly.AddSome(3);
            double result3 = poly.AddSome(2, 6);
            int result4 = poly.AddSome(5, null, null);
            double result5 = poly.AddSome(3, 4, 5, 6, 9, 12);

            Console.WriteLine("AddSome() \t\t\t: " + result1);
            Console.WriteLine("AddSome(3) \t\t\t: " + result2);
            Console.WriteLine("AddSome(2, 6) \t\t\t: " + result3);
            Console.WriteLine("AddSome(5, null, null) \t\t: " + result4);
            Console.WriteLine("AddSome(3, 4, 5, 6, 9, 12) \t: " + result5);
        }
    }
}
