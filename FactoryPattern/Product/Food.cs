using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public abstract class Food
    {
        protected double protineContents;

        public virtual void ShowProtineContents()
        {
            Console.WriteLine("The Protine contents of {0} are : {1} %", this.GetType().Name, this.protineContents);
        }
    }
}
