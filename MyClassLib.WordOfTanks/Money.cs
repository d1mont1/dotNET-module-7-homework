using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }
    }
}
