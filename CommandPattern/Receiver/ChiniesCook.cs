using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public class ChiniesCook : Receiver
    {
        public ChiniesCook(string name)
        {
            this.FoodName = name;
        }
        public override void CookFood()
        {
            Console.WriteLine("The food is [{0}] of type chainies preapred by {1}", FoodName, this.GetType().Name);
        }
    }
}
