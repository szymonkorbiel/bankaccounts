using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class UserAccount
    {

        public UserAccount(string accId, string curr)
        {
            this.AccountId = accId;

            if (curr == "PLN")
            {
                this.Currency = Currency.PLN;
            }
            else if (curr == "USD")
            {
                this.Currency = Currency.USD;
            }
            else if (curr == "EUR")
            {
                this.Currency = Currency.EUR;
            }
        }

        public string AccountId { get; set; }
        public User User { get; set; }
        public Currency Currency { get; set; }
        public float Balance { get; set; }
        public string IsLocked { get; set; }

    }

    enum Currency
    {
        PLN,
        EUR,
        USD
    };
}
