using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class MoneyEntry
    {
        public int NumberOfPennies()
        {
            Console.WriteLine("Enter amount of Pennies");
            int pennies = int.Parse(Console.ReadLine());
            return pennies;
        }

        public int NumberOfNickels()
        {
            Console.WriteLine("Enter amount of Nickels ");
            int nickels = int.Parse(Console.ReadLine());
            return nickels;
        }
        public int NumberOfDimes()
        {
            Console.WriteLine("Enter Amount of Dimes: ");
            int dimes = int.Parse(Console.ReadLine());
            return dimes;
        }
        public int NumberOfQuarters()
        {
            Console.WriteLine("Enter Amount of Quarters: ");
            int quarters = int.Parse(Console.ReadLine());
            return quarters;
        }
        
    }
}
