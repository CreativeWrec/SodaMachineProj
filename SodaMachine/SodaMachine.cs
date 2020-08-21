using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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
                UserInterface.DisplayCanCost(changeToAddToRegister);

                AddCoinsToRegisterForPurchase(sodaToRemove);
                //inventory[i] 
                //while (i > 10)
                //{

                //}

                // loop // (should end when we are done adding all coins)
                // decide which coin to add
                //Quarter quarter = new Quarter();
                //Dime dime = new Dime();
                //Nickle nickle = new Nickle();
                //Penny penny = new Penny();

                //register.Add(quarter);
                //register.Add(quarter);
                //register.Add(dime);
                //register.Add(nickle);
                //register.Add(penny);

               

                //changeToAddToRegister -= quarter.Value;
                // totalCost .35
                //////////////////////////////////////////////////////

                //register.Add(new Quarter());
            }
            else
            {
                // whoops...
                UserInterface.OutOfStock();
            }

            
        }

        public void AddCoinsToRegisterForPurchase(Can can)
        {
            double remainingChangeAmountToAdd = can.Cost;

            while() // while there is still change to be added to the register
            {
                // determine what coin to add to the register (using division?)
                // create (instantiate) the coin object to add to the register
                // add the created coin object to the register
                // lower the value of 'remainingChangeAmountToAdd by the value of the coin that was just added

                //Quarter quarter = new Quarter();
                //Dime dime = new Dime();


                if (remainingChangeAmountToAdd > .25) // we can add a quarter
                {
                    Quarter quarter = new Quarter();
                    register.Add(quarter);
                    remainingChangeAmountToAdd -= quarter.Value;
                }
                else if(remainingChangeAmountToAdd > .10) // we should add a dime next
                {
                    Dime dime = new Dime();
                    register.Add(dime);
                    remainingChangeAmountToAdd -= dime.Value;
                }
                else if (remainingChangeAmountToAdd > .05)
                {
                    Nickle nickle = new Nickle();
                    register.Add(nickle);
                    remainingChangeAmountToAdd -= nickle.Value;
                }
                else
                {
                    Penny penny = new Penny();
                    register.Add(penny);
                    remainingChangeAmountToAdd -= penny.Value;
                }
            }
        }
        
     
    }
}
