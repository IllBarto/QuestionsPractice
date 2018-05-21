using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Automapper
{
    class UserEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now.Date;
        public int Age { get; set; }
        public bool isActive { get; set; }
    }
}
