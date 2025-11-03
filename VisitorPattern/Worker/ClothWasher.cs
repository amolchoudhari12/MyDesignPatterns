using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    public class ClothWasher : IWork
    {
        public void Work(Customer customer)
        {
            switch (customer.IsDefaulter)
            {
                default:
                    break;
            }

            if (!customer.IsDefaulter)
                Console.WriteLine("Cloth washing is done for the Customer {0}  whose proffession is {1} ", customer.CustomerName, customer.Proffession);
        }
    }
}
