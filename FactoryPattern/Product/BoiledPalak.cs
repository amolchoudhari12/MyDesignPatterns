using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class BoiledPalak : Food
    {
        public BoiledPalak()
        {
            base.protineContents = 89;
        }
    }
}
