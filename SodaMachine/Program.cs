using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Soda_Machine sd = new Soda_Machine();
                sd.Transaction();
            }
            catch(Exception)
            {
                Console.WriteLine("soemthing went wrong..... lets try it again!");
                Console.ReadKey();
                Soda_Machine sm = new Soda_Machine();
                sm.Transaction();
            }
        }
    }
}
