using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public User(string id)
        {
            this.Id = id;
        }
        readonly string Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        readonly string Pesel;
        public string Address { get; set; }

        public List<UserAccount> Accounts;
    }
}
