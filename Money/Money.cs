using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        public int amount;
        public string unit;

        public Money(int Amount, string Unit)
        {
            amount = Amount;
            unit = Unit;

        }

        public static Money operator + (Money a, Money b)
        {
            Money temp = new Money(a.amount + b.amount, a.unit);
            return temp;
        }
        public static bool operator <(Money a, Money b)
        {
            if (a.amount<b.amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Money a, Money b)
        {
            if (a.amount > b.amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Money operator ++(Money a)
        {
            a.amount++;
            return a;
        }

        public static implicit operator Money(int val)
        {
            return new Money(val, "");
        }
        public static implicit operator Int32(Money m)
        {
            return m.amount;
        }
        public static implicit operator Money(string val)
        {
            return new Money(0, val);
        }
        public static explicit operator string(Money m)
        {
            return m.unit;
        }

    }
}
