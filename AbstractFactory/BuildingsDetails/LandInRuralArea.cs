using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AbstractFactory
{
    public class LandInRuralArea : Land
    {
        public LandInRuralArea()
        {

        }
        public LandInRuralArea(double area, string address)
        {
            base.Address = address;
            base.Area = area;
        }
    }
}
