﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces.Articles
{
    class TableArticle : IArticle
    {
        private static int Count = 0;

        public string Name { get; set; } = "Table";

        public TableArticle()
        {
            Count++;
        }

        public int GetNumberOfArticles()
        {
            return Count;
        }
    }
}
