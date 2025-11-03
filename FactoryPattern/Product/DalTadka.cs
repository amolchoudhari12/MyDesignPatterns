using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class DalTadka : Food
    {
        public DalTadka()
        {
            base.protineContents = 52;
        }
    }
}
