using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MultipleInheritance
{
    class GarrysPages : IBookStore
    {
        private Dictionary<string, decimal> books = new Dictionary<string, decimal>()
        {
            { "Snach", 12.34m },
            { "Brooklyn", 11.24m },
            { "Star Wars", 9m },
            { "Narnia", 5m}
        };

        public string Address => "Chicago, River Street, 12A.";

        public string Name => "Garry's Pages";

        public string GetInformation()
        {
            string mybooks = "";
            foreach (var item in books)
            {
                mybooks += "\t" + item.Key + "\n";
            }

            return "My store, " + Name + ", can be found in " + Address + "\n.Here you can find books like:\n" + mybooks +
                   "\nAnd many others...";
        }

        public decimal GetPrice(string bookName)
        {
            decimal price;
            bool found;
            string code = "search";

            do
            {
                found = books.TryGetValue(bookName, out price);

                if(found)
                {
                    return price;
                }
                else
                {
                    Console.WriteLine("There's no such book.");
                    Console.Write("\nExit? (yes/no) : ");
                    code = Console.ReadLine();

                    if (code != "yes")
                    {
                        Console.Write("\nSearch a books price: ");
                        bookName = Console.ReadLine();
                    }
                    else break;
                }
            } while (!found);

            throw new Exception("Couldn't find your book. Sorry :(");
        }
    }
}
