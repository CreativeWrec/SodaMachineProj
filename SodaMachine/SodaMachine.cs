using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables(Has A)
        public List<Coin> register;
        public List<Can> inventory;

        //Constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            InsertChangeInRegister();



        }
        //Methods(Can Do)
        public void InsertChangeInRegister()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
                
            }
            for(int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
            for(int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                register.Add(nickle);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }

        }

        public void InsertSodasInMachine()
        {
            for (int i = 0; i < 10; i++)
            {
                RootBeer rootBeer = new RootBeer();
                inventory.Add(rootBeer);
            }

        }
     
    }
}
