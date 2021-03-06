﻿using Practice.AttributesReflection;
using Practice.Automapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Practice.Abstractions;
using Practice.Collections;
using Practice.Extentions;
using Practice.Interfaces.Articles;
using Practice.MultipleInheritance;
using Practice.OOP_Principles;
using AutoMapper;
using InterviewPractice.Design_Patterns.StrategyPattern;
using InterviewPractice.Design_Patterns.StrategyPattern2;
using InterviewPractice.Design_Patterns.Singleton;
using System.Diagnostics;
using InterviewPractice.Concurrency;
using System.Threading.Tasks;
using System.Threading;
using InterviewPractice.Design_Patterns.Decorator;
using InterviewPractice.FluentAPI.Context;
using System.Data.SqlClient;
using InterviewPractice.CountObjects;
using InterviewPractice.OOP_Principles;
using InterviewPractice.Multithreading;
using InterviewPractice.JSON;
using InterviewPractice.Lock;

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
        public static void Perform_Polymorphism2()
        {
            Polymorphism2 poly = new Polymorphism2();

            poly.Method(3, 2, 3, 3);
        }
        public static void Perform_StrategyPattern()
        {
            StrategyContext st = null;

            Console.Write("Choose add (1)/ subts(2)/ mult(3): ");
            int input = int.Parse(Console.ReadLine());
            string method = "";
            switch (input)
            {
                case (1):
                    st = new StrategyContext(new Addition());
                    method = "Addition";
                    break;
                case (2):
                    st = new StrategyContext(new Substraction());
                    method = "Substraction";
                    break;
                case (3):
                    st = new StrategyContext(new Multiplication());
                    method = "Multiplication";
                    break;
            }

            int result = st.ExecuteOperation(2, 3);

            Console.WriteLine($"\nThe result of your {method} is {result}.");
        }
        public static void Perform_StragetyPattern2()
        {
            StrategyContext2 sContext = null;

            Console.WriteLine("Give message: ");
            string mess = Console.ReadLine();

            Console.Write("Text message (t) or email (e)? : ");
            string op = Console.ReadLine();

            if (op == "t")
                sContext = new StrategyContext2(new TextMessage());
            else if (op == "e")
                sContext = new StrategyContext2(new Email());

            if (sContext != null)
                sContext.PerformAction(mess);
        }
        public static void Perform_StrategySingleton()
        {
            SingleObject singleObject = SingleObject.GetInstance();

            singleObject.WriteMessage("Message from Singleton");
        }
        public static void Perform_Decorator()
        {
            BasicCar honda = new BasicCar();
            SportCar sportHonda = new SportCar(honda);

            Console.WriteLine($"Basic Honda: {honda.Model}, {honda.HorsPower} hors power, {honda.Consumption}l consumption, ${honda.Price} price.");
            Console.WriteLine($"Basic Honda: {sportHonda.Model}, {sportHonda.HorsPower} hors power, {sportHonda.Consumption}l consumption, ${sportHonda.Price} price.");
        }
        public static void Perform_EF()
        {
            using (var context = new MarketContext())
            {
                using (var dbTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        InterviewPractice.FluentAPI.Context.Market market = new InterviewPractice.FluentAPI.Context.Market()
                        {
                            Name = "Market2",
                            Location = "Straseni",
                            Products = new List<Product>()
                            {
                                new Product() { Name = "Food" },
                                new Product() { Name = "Clothes" }
                            }
                        };

                        context.Markets.Add(market);
                        context.SaveChanges();

                        dbTransaction.Commit();
                    }
                    catch
                    {
                        dbTransaction.Rollback();
                    }
                }

                List<InterviewPractice.FluentAPI.Context.Market> markets = new List<InterviewPractice.FluentAPI.Context.Market>();
                markets = context.Markets.Select(m => m).ToList();

                List<Product> m1p = new List<Product>();

                foreach (var m in markets)
                {
                    Console.WriteLine($"Market: {m.Name}, loc in {m.Location}.");
                }
            }
        }
        public static void Perform_StoredProcedure()
        {
            using (MarketContext context = new MarketContext())
            {
                var sqlParam = new SqlParameter("@id", 2);

                Product result = context.Database.SqlQuery<Product>("SelectProduct @id", sqlParam).SingleOrDefault();
                Console.WriteLine(result);
            }
        }
        public static void Perform_Count()
        {
            Car car1 = new Car();

            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine("Car counter : " + CarCounter.Count + "\nMy car counter : " + Car.MyCarCounter);
        }
        public static async void Perform_Concurrency()
        {

            var firstWatch = Stopwatch.StartNew();
            Helpers.CallFirstTask();
            Helpers.CallSecondTask();
            firstWatch.Stop();

            Console.WriteLine("\n\nAsync\n\n");
            Console.WriteLine("Wait 5 seconds...");
            Thread.Sleep(5000);

            var secondWatch = Stopwatch.StartNew();
            await Helpers.CallFirstTaskAsync();
            await Helpers.CallSecondTaskAsync();
            secondWatch.Stop();

            Console.WriteLine("\n\nSync version executed in : " + firstWatch.ElapsedMilliseconds);
            Console.WriteLine("Async version executed in : " + secondWatch.ElapsedMilliseconds);
        }
        public static void Perform_AsyncAwait()
        {
            HardWorker hw = new HardWorker();

            hw.BeginWork();
        }
        public static void Perform_JSON()
        {
            MyProduct prod = new MyProduct();
            prod.Name = "Sushi";
            prod.Price = 600;

            MyProduct prod2 = new MyProduct();
            prod2.Name = "Apples";
            prod2.Price = 10;

            IEnumerable<MyProduct> prods = new List<MyProduct>() { prod, prod2 };

            string jsonSushi = JsonWorker.ToJson(prods);

            Console.WriteLine(jsonSushi);

            string pr = JsonWorker.ToJson(prod2);
            List<MyProduct> desProd = JsonWorker.ToMyProducts(jsonSushi, null);
            Console.WriteLine("\nBack in products: \n");
            foreach (var item in desProd)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
        public static void Perform_Lock()
        {
            ListOperation<int> list = new ListOperation<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });

            Parallel.Invoke(() => list.AddElement(9), /*() => list.AddElement(9),*/ () => list.RemoveElement(9));

            Console.WriteLine("\nFinal");

            list.Display();
        }
    }

    class Helpers
    {
        public static void CallFirstTask()
        {
            MainThread.DoFirstTask(5);
        }

        public static async Task CallFirstTaskAsync()
        {
            await Task.Run(() => MainThread.DoFirstTask(5));
        }

        public static void CallSecondTask()
        {
            SecondThread.DoSecondTask(5);
        }

        public static async Task CallSecondTaskAsync()
        {
            await Task.Run(() => SecondThread.DoSecondTask(5));
        }
    }

    static class CarCounter
    {
        public static int Count = 0;
    }
}
