using InterfaceImplementation.Interfaces.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.Interfaces.Articles
{
    class ChairArticle : IArticle
    {
        private Counter counter = new Counter();
        public string Name { get; set; } = "Chair";

        public ChairArticle()
        {
            Interlocked.Increment(ref counter.NumberOfUnits);
        }

        public int GetNumberOfArticles()
        {
            return counter.NumberOfUnits;
        }

        public void DoStuff()
        {

        }
    }
}
