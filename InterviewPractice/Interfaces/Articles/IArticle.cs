﻿using InterfaceImplementation.Interfaces.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces.Articles
{
    interface IArticle
    {
        string Name { get; set; }

        int GetNumberOfArticles();
    }
}