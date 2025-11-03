using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class BoiledRice : Food
    {
        public BoiledRice()
        {
            base.protineContents = 75;
        }

        public override void ShowProtineContents()
        {
            Console.WriteLine("The Protine contents of {0} are : {1} % , Ideal to eat to everyday  ....", this.GetType().Name, base.protineContents);
        }
    }
}
