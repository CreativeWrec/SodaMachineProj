﻿using System;
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
            Coin penny = new Penny();
            double totalChange = 0;
            totalChange += penny.Value;

            List<int> numbers = new List<int>() { 5, 4, 3, 2, 1 };
            Console.WriteLine(numbers.Count);

            numbers.Count = 10;

            for(int i = 0; i < numbers.Count; i++)
            {

            }

            Console.WriteLine();
            UserInterface.DisplayOpeningMessage();

            Simulation simulation = new Simulation();
            simulation.;
        }
    }
}

//Soda Machine Welcome Screen
//1. Display the available items & how much each item cost
//2. Prompt user to make a selection
//3. Ask customer how many they would like to purchase

//Customer
//4.View
