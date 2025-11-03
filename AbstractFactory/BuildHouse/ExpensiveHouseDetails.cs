using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyDesignPatterns.AbstractFactory
{
    public class ExpensiveHouseDetails : BuildHouseFactory
    {
        public override Land GetLand()
        {
            return new LandInCityArea(200000, "Karegaon Park");
        }

        public override BuildingStructure GetBuildingStructure()
        {
            return new MultiStoryApartments("Expensive Luxerious homes");
        }
    }
}
