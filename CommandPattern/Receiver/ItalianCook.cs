using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public class ItalianCook : Receiver
    {
        public ItalianCook(string name)
        {
            this.FoodName = name;
        }
        public override void CookFood()
        {
            Console.WriteLine("The food is [{0}] of type italian preapred by {1}", FoodName, this.GetType().Name);
        }
    }
}
