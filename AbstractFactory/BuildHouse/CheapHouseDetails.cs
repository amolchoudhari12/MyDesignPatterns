using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyDesignPatterns.AbstractFactory
{
    public class CheapHouseDetails : BuildHouseFactory
    {
        public override Land GetLand()
        {
            return new LandInRuralArea(200000, "Uruli Kanchan");
        }

        public override BuildingStructure GetBuildingStructure()
        {
            return new SingleStoryApartments("Cheap afforable homes");
        }
    }
}
