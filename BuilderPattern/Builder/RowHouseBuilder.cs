using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern.Builder
{
    public class RowHouseBuilder : HouseBuilder
    {

        public RowHouseBuilder( House house)
        {
            this.House = house;
            this.House.HouseType = HouseType.RowHouse;
        }
        public override void GetLand()
        {
            this.House.Area = 3020;
        }

        public override void CreatePlan()
        {
            this.House.Architecture = "RowHouse building";
        }

        public override void DoConstruction()
        {
            this.House.NoOfBedRooms = 3;
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
