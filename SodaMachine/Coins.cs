using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Coins
    {
        Penny pennies;
        Nickel nickel;
        Dime dimes;
        Quarter quarter;

        public Coins(Penny pennies, Nickel nickel, Dime dimes, Quarter quarter)
        {
            this.pennies = pennies;
            this.nickel = nickel;
            this.dimes = dimes;
            this.quarter = quarter;
        }

    }
}
