using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyDesignPatterns.MediatorPattern.Mediator
{
    public class AirCraft
    {
        public AirCraftController AirCraftController { get; set; }

        public string AirCraftID { get; set; }
        public string Name { get; set; }

        protected int timeToLoad;
        public int TimeToLoad { get { return timeToLoad; } }

        public virtual void Depart()
        {
            LoadAirCraft();
            Console.WriteLine("{0} of  {1} departed from {2} terminal at {3} \n", this.AirCraftID, this.Name, AirCraftController.GetType().Name, System.DateTime.Now);
            AirCraftController.NotifyTookOFF(this.AirCraftID);
            
        }

        public virtual void LoadAirCraft()
        {
            Thread.Sleep(timeToLoad);
        }

        public virtual void Arrive()
        {
            AirCraftController.NotifyArrived(this);
        }

    }
}
