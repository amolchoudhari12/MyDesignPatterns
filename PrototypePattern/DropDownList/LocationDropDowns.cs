using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.PrototypePattern
{
    public class LocationDropDowns : ClonePrototype
    {
        public List<DropDownItem> Countries { get; set; }
        public List<DropDownItem> States { get; set; }
        public List<DropDownItem> LocalArea { get; set; }


        public LocationDropDowns()
        {
            //Fetching the records from DBs

            Countries = new List<DropDownItem>();
            Countries.Add(new DropDownItem(1, "India"));
            Countries.Add(new DropDownItem(2, "South Africa"));
            Countries.Add(new DropDownItem(3, "Australia"));
            Countries.Add(new DropDownItem(4, "UK"));
            Countries.Add(new DropDownItem(5, "Afganistan"));
            Countries.Add(new DropDownItem(6, "USA"));

            States = new List<DropDownItem>();
            States.Add(new DropDownItem(1, 1, "Maharastra"));
            States.Add(new DropDownItem(2, 1, "Goa"));
            States.Add(new DropDownItem(3, 1, "Karanataka"));
            States.Add(new DropDownItem(4, 1, "Hydrabaad"));
            States.Add(new DropDownItem(5, 1, "Delhi"));
            States.Add(new DropDownItem(6, 1, "Kolkatta"));

            States.Add(new DropDownItem(1, 2, "Kwasunatal"));
            States.Add(new DropDownItem(2, 2, "Lysetho"));
            States.Add(new DropDownItem(3, 2, "CrogerPak"));
            States.Add(new DropDownItem(4, 2, "Sanipaas"));

            LocalArea = new List<DropDownItem>();
            LocalArea.Add(new DropDownItem(1, 1, "Pune"));
            LocalArea.Add(new DropDownItem(2, 1, "Nashik"));
            LocalArea.Add(new DropDownItem(3, 1, "Mumbai"));
            LocalArea.Add(new DropDownItem(4, 2, "Panji"));
            LocalArea.Add(new DropDownItem(5, 3, "Banglore"));
            LocalArea.Add(new DropDownItem(6, 3, "Manglore"));


            LocalArea.Add(new DropDownItem(7, 1, "Druban"));
            LocalArea.Add(new DropDownItem(8, 1, "Peterzbirg"));
            LocalArea.Add(new DropDownItem(9, 1, "Ushakha"));
            LocalArea.Add(new DropDownItem(10, 2, "Lys"));
            LocalArea.Add(new DropDownItem(11, 3, "JohanceBirg"));
            LocalArea.Add(new DropDownItem(12, 3, "CapeTwon"));
            ShowDetails();
        }

        public override ClonePrototype Clone()
        {
            ShowDetails();
            return (ClonePrototype)this.MemberwiseClone();
        }

        public void ShowDetails()
        {
            Console.WriteLine("Countries : {0}", Countries.Count);
            Console.WriteLine("States : {0}", States.Count);
            Console.WriteLine("LocalArea : {0}", LocalArea.Count);
        }
    }
}
