using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern.Builder
{
    public class ApartmentBuilder : HouseBuilder
    {

        public ApartmentBuilder(House house)
        {
            House = house;
            this.House.HouseType = HouseType.Aprtment;
        }
        public override void GetLand()
        {
            this.House.Area = 2000000;
        }

        public override void CreatePlan()
        {
            this.House.Architecture = "MultiStory building";
        }

        public override void DoConstruction()
        {
            this.House.NoOfBedRooms = 2;
        }

        public override void Paint()
        {
            this.House.Color = "Light Brown";
        }

        public override House GetHouse()
        {
            return this.House;
        }
    }
}
