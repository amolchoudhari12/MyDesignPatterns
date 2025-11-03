using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    public class DishWasher : IWork
    {
        public void Work(Customer customer)
        {
            Console.WriteLine("Dish washing is done for customer {0}  whose proffession is {1}", customer.CustomerName, customer.Proffession);
        }

       
    }
}
