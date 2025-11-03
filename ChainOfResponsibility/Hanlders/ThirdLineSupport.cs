using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility.Hanlders
{
    public class ThirdLineSupport :AbstractSupport
    {
        public ThirdLineSupport()
        {
            this.MinComplexity = 8;
            this.MaxComplexity = 10;
        }
       
    }
}
