using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.FluentAPI.Context
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Market> Markets { get; set; }
    }
}
