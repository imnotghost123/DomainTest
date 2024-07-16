using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            if (string.IsNullOrEmpty(currency)) throw new ArgumentException("Currency cannot be empty.");

            Amount = amount;
            Currency = currency;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }

        public Money Add(decimal amount)
        {
            return new Money(Amount + amount, Currency);
        }

        public Money Subtract(decimal amount)
        {
            if (Amount < amount) throw new InvalidOperationException("Insufficient funds.");
            return new Money(Amount - amount, Currency);
        }
    }
}
