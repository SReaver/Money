using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {


        static void Main(string[] args)
        {

            Money usd1 = new Money(1, "USD");
            Money usd2 = new Money(3, "USD");
            usd1++;
            Console.WriteLine(usd1.amount + " "+usd1.unit);

        

            if (usd1<usd2)
            {
                Console.WriteLine("usd1 Больше");
            }

            Money m1 = 56; //используя implicit
            int i = m1; //преобразование в другой тип
            Money ms = "USD";
            string s = ms;
        
        }
    }
}
