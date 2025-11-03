using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AbstractFactory
{
    public class RealEstateClient
    {
        private Land Land;
        private BuildingStructure BuildingStructure;

        public RealEstateClient(BuildHouseFactory factory)
        {
            Land = factory.GetLand();
            BuildingStructure = factory.GetBuildingStructure();
        }

        public void ConstructHouses()
        {
            Console.WriteLine("\nWe are building {2}  in the area of  {0} sqft area at location of {1}", Land.Area, Land.Address, BuildingStructure.Type);
        }
    }
}
