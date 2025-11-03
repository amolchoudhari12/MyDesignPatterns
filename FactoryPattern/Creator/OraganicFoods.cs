using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class OraganicFoods : FoodFactory
    {
        public OraganicFoods()
        {
            FoodItems = new List<Food>();
        }

        public override List<Food> CreateFood()
        {
            FoodItems.Add(new MethiSubji());
            FoodItems.Add(new BoiledPalak());
            FoodItems.Add(new BoiledRice());
            return FoodItems;
        }
    }
}
