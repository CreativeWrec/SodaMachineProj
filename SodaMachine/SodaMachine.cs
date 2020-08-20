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

        public int InsertSodasInMachine()
        {
            for (int i = 0; i < 10; i++)
            {
                RootBeer rootBeer = new RootBeer();
                inventory.Add(rootBeer);
            }
            for (int i = 0; i < 10; i++)
            {
                Orange_Soda orange_Soda = new Orange_Soda();
                inventory.Add(orange_Soda);
            }
            for (int i = 0; i < 10; i++)
            {
                Cola cola = new Cola();
                inventory.Add(cola);
            }
            return inventory.Count();
        }

        public void BuyingSodaCans(string sodaSelection)
        {
            Can sodaToRemove = null;

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i].name);
                if(inventory[i].name == sodaSelection) // the name of soda we are on matches 'sodaSelection'
                {
                    // inventory.Remove(inventory[i]);
                    sodaToRemove = inventory[i];
                    inventory.RemoveAt(i);
                    break;
                }
            }

            if(sodaToRemove != null)
            {
                 
                double changeToAddToRegister = sodaToRemove.Cost;
                
                // loop // (should end when we are done adding all coins)
                // decide which coin to add
                Quarter quarter = new Quarter();
                register.Add(quarter);
                changeToAddToRegister -= quarter.Value;
                // totalCost .35
                //////////////////////////////////////////////////////

                register.Add(new Quarter());
            }
            else
            {
                // whoops...
            }

            
        }
        
     
    }
}
