using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.MediatorPattern.Mediator
{
    public class ShivajiTerminalAirport : AirCraftController
    {
        public ShivajiTerminalAirport()
        {
            ListOfAirCraftsOnTerminal = new List<AirCraft>();
            FlyQueueForAirCraft = new Queue<string>();
        }

        public override void NotifyArrived(AirCraft airCraft)
        {
            ListOfAirCraftsOnTerminal.Add(airCraft);

            FlyQueueForAirCraft.Enqueue(airCraft.AirCraftID);

            airCraft.AirCraftController = this;
        }

        public override void NotifyTookOFF(string airCraftID)
        {
            ListOfAirCraftsOnTerminal.Remove(ListOfAirCraftsOnTerminal.Where(x => x.AirCraftID == airCraftID).FirstOrDefault());
            if (FlyQueueForAirCraft != null)
            {
                string flyCandidate = GetNextAirCraft();
                if (flyCandidate != string.Empty)
                    NotifyGreenSignal(flyCandidate);
                else
                    Console.WriteLine("{0} is empty of aricrafts", this.GetType().Name);
            }

        }

        public string GetNextAirCraft()
        {
            if (FlyQueueForAirCraft.Count > 0)
                return FlyQueueForAirCraft.Dequeue();
            else
                return string.Empty;

        }

        public override void NotifyGreenSignal(string ToPlaneID)
        {
            List<string> waitingList = ListOfAirCraftsOnTerminal.Where(x => x.AirCraftID != ToPlaneID).Select(x => x.AirCraftID).ToList();
            NotifyRedSignals(waitingList);

            Console.WriteLine("{0} Showing Green Signal to  Aircraft of ID : {1}", this.GetType().Name, ToPlaneID);
            AirCraft craft = ListOfAirCraftsOnTerminal.Where(x => x.AirCraftID == ToPlaneID).FirstOrDefault();
            craft.Depart();

        }

        protected override void NotifyRedSignals(List<string> toPlanes)
        {
            foreach (var item in toPlanes)
            {
                Console.WriteLine("{0} Showing Red to  Aircraft of ID : {1}", this.GetType().Name, item);
            }
        }
    }
}
