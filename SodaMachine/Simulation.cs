using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        //Member Variables(Has A)
        public SodaMachine sodaMachine;
        public Customer customer;
        //Constructor
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();

        }
        //Methods(Can Do)
        public void RunSimulation()
        {
            // step 1
            // step 2
            // step 3
            sodaMachine.BuyingSodaCans();

        }

    }
}
