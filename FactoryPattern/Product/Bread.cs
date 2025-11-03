using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class Bread : Food
    {
        public Bread()
        {
            base.protineContents = 40;
        }
    }

}
