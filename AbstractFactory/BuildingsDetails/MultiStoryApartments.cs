using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AbstractFactory
{
    public class MultiStoryApartments : BuildingStructure
    {
        public MultiStoryApartments()
        {

        }
        public MultiStoryApartments(string type)
        {
            base.Type = type;
        }
    }
}
