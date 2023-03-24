using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_3
{
    class Ors
    {
        private static int Counter;
        public static int amountGoldAll
        {
            get;
            private set;
        }
        public int amountGold
        {
            get;
            private set;
        }
        public Ors()
        {
            Counter++;
            amountGoldAll += 2;
            if (Counter > 5)
            {
                amountGold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ors ors_1 = new Ors();
            Console.WriteLine(Ors.amountGoldAll);
            Ors ors_2 = new Ors();
            Ors ors_3 = new Ors();
            Console.WriteLine(Orc.amountGoldAll);
            Ors ors_4 = new Ors();
            Ors ors_5 = new Ors();
            Ors ors_6 = new Ors();
            Console.WriteLine(orc_6.amountGold);
            Console.ReadKey(true);
        }
    }
}