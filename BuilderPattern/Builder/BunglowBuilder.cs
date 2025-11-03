using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern.Builder
{
    public class BunglowBuilder : HouseBuilder
    {

        public BunglowBuilder(House house)
        {
            this.House = house;
            this.House.HouseType = HouseType.Bunglow;
        }

        public override void GetLand()
        {
            this.House.Area = 10000;
        }

        public override void CreatePlan()
        {
            this.House.Architecture = "Bunglow building";
        }

        public override void DoConstruction()
        {
            this.House.NoOfBedRooms = 18;
        }

        public override void Paint()
        {
            this.House.Color = "Whilte";
        }

        public override House GetHouse()
        {
            return this.House;
        }
    }
}
