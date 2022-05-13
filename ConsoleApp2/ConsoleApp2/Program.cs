using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string basePath = @"C:\Users\Szymon\source\repos\ConsoleApp2\ConsoleApp2\data\";
            string peaoplePath = $"{basePath}osoby.csv";
            string accountPath = $"{basePath}konta.csv";

            string[] readText = File.ReadAllLines(accountPath);

            int i = 0;
            List<UserAccount> accounts = new List<UserAccount>();
            Reader reader = new Reader();
            List<User> users = reader.readUsers(peaoplePath);
        }
    }
}
