using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern.Builder
{
    public class PentHouseBuilder : HouseBuilder
    {
        public PentHouseBuilder(House house)
        {
            this.House = house;
            this.House.HouseType = HouseType.PentHouse;
        }
        public override void GetLand()
        {
            this.House.Area = 5999;
        }

        public override void CreatePlan()
        {
            this.House.Architecture = "PenHouse building";
        }

        public override void DoConstruction()
        {
            this.House.NoOfBedRooms = 5;
        }

        public override void Paint()
        {
            this.House.Color = "Dark Blue";
        }

        public override House GetHouse()
        {
            return this.House;
        }
    }
}
