using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class FigerFries : Food
    {
        public FigerFries()
        {
            base.protineContents = 30;
        }
        public override void ShowProtineContents()
        {
            Console.WriteLine("The Protine contents of {0} are : {1} % , Warning ..Awaid eat regularly !", this.GetType().Name, base.protineContents);
        } 
    }
}
