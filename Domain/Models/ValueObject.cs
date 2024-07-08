using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class ValueObject :IEquatable<ValueObject>
    {
        public abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if ((obj is null || obj.GetType() != GetType()))
            {
                return false;
            }

            var valueObject = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
            //  return base.Equals(obj);

        }

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !Equals(left, right);
        }

        //why this code cause want to valu object return same hash code
        public override int GetHashCode()
        {

            return GetEqualityComponents().Select(x => x?.GetHashCode() ?? 0).Aggregate((x, y) => x ^ y);
            //   return base.GetHashCode();
        }

        public bool Equals(ValueObject? other)
        {
            return Equals((object?)other);
        }

    }

    public class Price : ValueObject
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Price(decimal amt, string currency)
        {
            Amount = amt;
            Currency = currency;
        }

        //this method use to return in order class 
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
}
