using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyDesignPatterns.AbstractFactory
{
    public abstract class BuildHouseFactory
    {
        public abstract Land GetLand();
        public abstract BuildingStructure GetBuildingStructure();
    }
}
