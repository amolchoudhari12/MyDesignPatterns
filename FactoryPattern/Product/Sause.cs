using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class Sause : Food
    {
        public Sause()
        {
            base.protineContents = 34;
        }

        public override void ShowProtineContents()
        {
            Console.WriteLine("The Protine contents of {0}  are : {1} %  Warning.....Beaware of exessive eat ", this.GetType().Name,  this.protineContents);
        }
    }
}
