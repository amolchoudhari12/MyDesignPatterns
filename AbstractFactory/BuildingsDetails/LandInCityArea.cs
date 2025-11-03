using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AbstractFactory
{
    public class LandInCityArea : Land
    {
        public LandInCityArea()
        {

        }

        public LandInCityArea(double area, string address)
        {
            base.Address = address;
            base.Area = area;
        }
    }
}
