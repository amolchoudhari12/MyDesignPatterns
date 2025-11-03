using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern
{
    public abstract class HouseBuilder
    {
        public House House { get; set; }

        public abstract void GetLand();
        public abstract void CreatePlan();
        public abstract void DoConstruction();
        public abstract void Paint();

        public abstract House GetHouse();
        
    }
}
