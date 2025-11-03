using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public class Waiter
    {
        List<Receiver> ListOfCookers;
        private List<CookCommand> PlaceOrderCommands;

        public void SetPlaceOrder(List<CookCommand> commands)
        {
            this.PlaceOrderCommands = commands;
        }

        public void PlaceOrder()
        {
            foreach (var item in PlaceOrderCommands)
            {
                item.Execute();
            }
        }       
    }
}
