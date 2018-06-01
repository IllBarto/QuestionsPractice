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
        private static int Count = 0;
        public string Name { get; set; } = "Chair";

        public ChairArticle()
        {
            Count++;
        }

        public int GetNumberOfArticles()
        {
            return Count;
        }

        public void DoStuff()
        {

        }
    }
}
