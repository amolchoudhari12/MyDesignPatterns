using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.MediatorPattern.Mediator
{
    public class LuguageAirCraft : AirCraft
    {

        public LuguageAirCraft(string id, string name, int timeToTakeOFF)
        {
            this.AirCraftID = id;
            this.Name = name;
            this.timeToLoad = timeToTakeOFF;
        }
       
    }
}
