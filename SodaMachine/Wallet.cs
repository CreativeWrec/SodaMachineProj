using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables(Has A)
        public List<Coin> coins;
        public Card card;

        //Constructor
        public Wallet()
        {
                
        }
        //Methods(Can Do)
        public void MoneyInWallet()
        {
            for (int i = 0; i < 4; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                coins.Add(nickle);
            }
            for (int i = 0; i < 100; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }
        }
    }
}
