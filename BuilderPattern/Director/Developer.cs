using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern
{
    public class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            this.Name = name;
        }

        public House Construct(HouseBuilder builder)
        {
            builder.GetLand();
            builder.CreatePlan();
            builder.DoConstruction();
            builder.Paint();
            return builder.GetHouse();
        }
    }
}
