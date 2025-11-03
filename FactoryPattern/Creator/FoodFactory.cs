using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.FactoryPattern
{
    public abstract class FoodFactory
    {
        protected List<Food> FoodItems;
        public abstract List<Food> CreateFood();
    }
}
