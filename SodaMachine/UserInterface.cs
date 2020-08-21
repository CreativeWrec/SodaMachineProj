using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        public static void DisplayOpeningMessage()
        {
            Console.WriteLine("Welcome to the soda machine!");
            Console.WriteLine("These items are what's readily available");


        }
        public static string AskForSodaType()
        {
            Console.WriteLine("Please type Cola");
            Console.WriteLine("Please type Orange Soda");
            Console.WriteLine("Please type Root Beer");

            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void DisplayCanCost(double canCost)
        {
            Console.WriteLine("That soda cost this much" + canCost);
        }

        public static void AskForAmountNeeded()
        {
            Console.WriteLine("Please enter the amount displayed");
        }
        public static void OutOfStock()
        {
            Console.WriteLine("All out of that flavor! Feel free to make another choice!");
        }
    }
}
