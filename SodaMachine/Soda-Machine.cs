using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Soda_Machine: CoinsMaker
    {
        int GrapeSodaAmount = 10;
        int OrangeSodaAmount = 10;
        int MeatSodaAmount = 10;

        int GrapeSodaPrice = 60;
        int OrangeSodaPrice = 35;
        int MeatSodaPrice = 6;
        int totalMoneyUser = 0;

        string option = "";
        List<Penny> totalPennies;
        List<Nickel> totalNickels;
        List<Dime> totalDimes;
        List<Quarter> totalQuarters ;

        MoneyEntry money = new MoneyEntry();
        static void SodaSelection()
        {
            Console.WriteLine("**************************************"
                             +"\n           1 - Grape Soda   60cents   "
                             +"\n           2 - Orange Soda  35cents   "
                             +"\n           3 - Meat Soda     6cents   "
                             +"\n           4 - Exit                   "
                             +"\n**************************************");
        }
        public void Transaction()
        {
            totalPennies = Pennies();
            totalNickels = Nickels();
            totalDimes = Dimes();
            totalQuarters = Quarters();
            while (option != "exit" || option!= "4")
            {
                Console.WriteLine("Please Deposite your Coins ");
                int totalPenniesUser = money.NumberOfPennies();
                int totalNickelsUser= money.NumberOfNickels();
                int totalDimesUser = money.NumberOfDimes();
                int totalQuarterUser = money.NumberOfQuarters();
                totalMoneyUser = (totalPenniesUser * PennyValue) + (totalNickelsUser * NickelValue) + (totalNickelsUser * NickelValue) +(totalQuarterUser * QuarterValue);
                SodaSelection();
                Console.WriteLine("your Money total is :"+ totalMoneyUser);
                option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        if (totalMoneyUser >= GrapeSodaPrice && GrapeSodaAmount > 0)
                        {
                            MoneyAdder(new Penny(PennyValue),totalPenniesUser, totalPennies);
                            MoneyAdder(new Nickel(NickelValue), totalNickelsUser, totalNickels);
                            MoneyAdder(new Dime(DimeValue), totalNickelsUser, totalDimes);
                            MoneyAdder(new Quarter(QuarterValue), totalQuarterUser, totalQuarters);
                            int UserChange = totalMoneyUser - GrapeSodaPrice;
                            Console.WriteLine("One GrapeSoda Ready......");
                            Console.WriteLine("Your Change is : {0}", UserChange+ "\n ....Thanks..");
                            ChangetoReturn(UserChange);
                            Console.ReadKey();
                            Console.Clear();
                            GrapeSodaAmount--;
                        }
                        else if (totalPennies.Count >0 && totalDimes.Count >0)
                        {
                            Console.WriteLine("Unable to fulfill operation "
                                              +"\nPlease take Your money Back ");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        else
                        {
                            Console.WriteLine("No enough money for this transaction please Try again ....");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        break;

                    case "2":
                        if (totalMoneyUser>= OrangeSodaPrice && OrangeSodaAmount > 0)
                        {
                            MoneyAdder(new Penny(PennyValue), totalPenniesUser, totalPennies);
                            MoneyAdder(new Nickel(NickelValue), totalNickelsUser, totalNickels);
                            MoneyAdder(new Dime(DimeValue), totalNickelsUser, totalDimes);
                            MoneyAdder(new Quarter(QuarterValue), totalQuarterUser, totalQuarters);
                            int UserChange = totalMoneyUser - OrangeSodaPrice;
                            Console.WriteLine("Your Change is : {0}", totalMoneyUser - OrangeSodaPrice);
                            ChangetoReturn(UserChange);
                            OrangeSodaAmount--;
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        else if (totalPennies.Count > 0 && totalDimes.Count >0)
                        {
                            Console.WriteLine("Unable to fulfill operation "
                                               + "\n Please take Your money Back ");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        else
                        {
                            Console.WriteLine("No enough money for this transaction please Try again ....");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        break;

                    case "3":
                        if(totalMoneyUser >= MeatSodaPrice && MeatSodaAmount > 0)
                        {
                            MoneyAdder(new Penny(PennyValue), totalPenniesUser, totalPennies);
                            MoneyAdder(new Nickel(NickelValue), totalNickelsUser, totalNickels);
                            MoneyAdder(new Dime(DimeValue), totalNickelsUser, totalDimes);
                            MoneyAdder(new Quarter(QuarterValue), totalQuarterUser, totalQuarters);
                            int UserChange = totalMoneyUser - MeatSodaPrice;
                            Console.WriteLine("Your Change is : {0}", UserChange);
                            ChangetoReturn(UserChange);
                            MeatSodaAmount--;
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        else if (totalPennies.Count > 0&& totalDimes.Count >0)
                        {
                            Console.WriteLine("Unable to fulfill operation "
                                               + "\n Please take Your money Back ");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        else
                        {
                            Console.WriteLine("No enough money for this transaction please Try again ....");
                            Console.ReadKey();
                            Console.Clear();
                            Transaction();
                        }
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option ...... please Try again");
                        Console.Clear();
                        Transaction();
                        break;
                }
            }
        }
        public void ChangetoReturn(int ValueUserChange)
        {

            List<Coins> ChangeToUser = ChangeInCoins(ValueUserChange);
            int PenniesAmount = ChangeToUser.Where(x => x.GetType() == typeof(Penny)).Count();
            int QuarterAmount = ChangeToUser.Where(x => x.GetType() == typeof(Quarter)).Count();
            int DimesAmount = ChangeToUser.Where(x => x.GetType() == typeof(Dime)).Count();
            int NicklesAmount = ChangeToUser.Where(x => x.GetType() == typeof(Nickel)).Count();
            MoneyRemover(new Penny(PennyValue), PenniesAmount, totalPennies);
            MoneyRemover(new Quarter(QuarterValue), QuarterAmount, totalQuarters);
            MoneyRemover(new Dime(DimeValue), DimesAmount, totalDimes);
            MoneyRemover(new Nickel(NickelValue), NicklesAmount, totalNickels);
        }
    }
}
