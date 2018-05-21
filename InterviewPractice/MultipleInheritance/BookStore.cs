using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MultipleInheritance
{
    abstract class BookStore
    {
        public abstract int GetTotalBooks();

        public virtual string GetBookEmail()
        {
            return "bookstore@mail.com";
        }
    }
}
