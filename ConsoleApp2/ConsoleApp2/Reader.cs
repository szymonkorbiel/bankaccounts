using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Reader
    {
        public List<User> readUsers(string file)
        {

            return File.ReadAllLines(file).Skip(1).Select(v => createUser(v)).ToList();
        }

        public List<UserAccount> readAccounts(string file)
        {

            return File.ReadAllLines(file).Skip(1).Select(v => createAccount(v)).ToList();
        }

        public User createUser(string row)
        {
            string[] values = row.Split(";");
            User user = new User(values[0]);
            user.FirstName = values[1];
            user.LastName = values[2];
            user.Address = values[4];
            return user;
        }

        public UserAccount createAccount(string row)
        {
            string[] values = row.Split(";");
            UserAccount account = new UserAccount(values[0], values[2]);
            account.AccountId = values[0];
            account.Balance = float.Parse(values[3]);
            account.IsLocked = values[4];
            return account;
        }
    }
}
