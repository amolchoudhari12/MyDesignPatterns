using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public class FastFoods : FoodFactory
    {
        public FastFoods()
        {
            FoodItems = new List<Food>();
        }


        public override List<Food> CreateFood()
        {
            FoodItems.Add(new Bread());
            FoodItems.Add(new DalTadka());
            FoodItems.Add(new FigerFries());
            FoodItems.Add(new Sause());
            return FoodItems;
        }
    }
}
