using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AbstractFactory
{
    public class SingleStoryApartments : BuildingStructure
    {
        public SingleStoryApartments()
        {

        }
        public SingleStoryApartments(string type)
        {
            base.Type = type;
        }
    }
}
