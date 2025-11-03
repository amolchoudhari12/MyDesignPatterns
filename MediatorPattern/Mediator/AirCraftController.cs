using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.MediatorPattern.Mediator;

namespace MyDesignPatterns.MediatorPattern
{
    public abstract class AirCraftController
    {
        protected List<AirCraft> ListOfAirCraftsOnTerminal { get; set; }

        protected Queue<string> FlyQueueForAirCraft { get; set; }

        public abstract void NotifyArrived(AirCraft airCraft);

        public abstract void NotifyTookOFF(string airCraftID);

        public abstract void NotifyGreenSignal(string ToPlane);

        protected abstract void NotifyRedSignals(List<String> ToPlanes);
    }
}
