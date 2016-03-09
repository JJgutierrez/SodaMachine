using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class CoinsMaker
    {
        public int PennyValue = 1;
        public int NickelValue = 5;
        public int DimeValue = 10;
        public int QuarterValue = 25;
        
        public List<Penny> Pennies()
        {
            List<Penny> tempPennies = new List<Penny>();
            for(int i = 0; i<= 50; i++)
            {
                tempPennies.Add(new Penny(PennyValue));
            }
            return tempPennies;
        }

        public List<Dime> Dimes()
        {
            List<Dime> tempDimes = new List<Dime>();
            for(int i = 0; i<= 10; i++)
            {
                tempDimes.Add(new Dime(DimeValue));
            }
            return tempDimes;
        }
        public List<Nickel> Nickels()
        {
            List<Nickel> tempNickels = new List<Nickel>();
            for (int i = 0; i <= 20; i++)
            {
                tempNickels.Add(new Nickel(NickelValue));
            }
            return tempNickels;
        }
        public List<Quarter> Quarters()
        {
            List<Quarter> tempQuarter = new List<Quarter>();
            for (int i = 0; i <= 20; i++)
            {
                tempQuarter.Add(new Quarter(QuarterValue));
            }
            return tempQuarter;
        }
        public void MoneyAdder<T>(T item, int AmountOfCoins, List<T> money)
        {
           
            for (int i = 0; i < AmountOfCoins; i++)
            {
                money.Add(item);
            }
        }
        public void MoneyRemover<T>(T item, int amountOfCoins, List<T>money)
        {
            for (int i = 0; i< amountOfCoins; i++)
            {
                money.Remove(item);
            }
        }
        public List<Coins> ChangeInCoins(int ChangeValue)
        {
            int quartersAmount = (int)(ChangeValue / QuarterValue);
            int dimesAmount = (int)(ChangeValue % QuarterValue) / DimeValue;
            int nickelsAmount = (int)((ChangeValue%QuarterValue)%DimeValue)/ NickelValue;
            int penniesAmount = (int)(((ChangeValue % QuarterValue) % DimeValue) % NickelValue) / PennyValue;

            List<Coins> changeCoins = new List<Coins>();

            changeCoins.Add(new Coins(new Penny(penniesAmount), new Nickel(nickelsAmount), new Dime(dimesAmount), new Quarter(quartersAmount)));
            return changeCoins;
        }
    }
}
