using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MultipleInheritance
{
    class MollysBooks:BookStore, IBookStore
    {
        private Dictionary<string, decimal> books = new Dictionary<string, decimal>()
        {
            { "Game Of Thrones", 12.34m },
            { "Dark Tower", 11.24m },
            { "Star Wars", 9m },
            { "Narnia", 5m}
        };

        public override int GetTotalBooks()
        {
            return books.Count();
        }

        public string Address { get { return "Washington, D.C."; } }
        public string Name { get { return "Molly's Books"; } }

        public decimal GetPrice(string bookName)
        {
            decimal price;
            bool bookFound =  books.TryGetValue(bookName, out price);

            if (bookFound)
            {
                return price;
            }

            throw new Exception("There is no such book in the store.");
        }

        public string GetInformation()
        {
            return "Book Store: " + Name + ". Located in " + Address + ".\nThere are " + GetTotalBooks().ToString() + 
                   " books in the store.";
        }
    }
}
