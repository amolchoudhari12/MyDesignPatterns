using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.ObserverPattern.Subject;

namespace MyDesignPatterns.ObserverPattern.Observer
{
    public class PropertySeeker : IPropertySeeker
    {
        public string Name { get; set; }
        public ListedProperty ListedProperty { get; set; }

        public PropertySeeker(string name)
        {
            this.Name = name;
        }

        public bool SendNotification(Subject.ListedProperty listerProperty)
        {
            Console.WriteLine("Notifying {0} for the property  in {1} with {2} state ", Name, listerProperty.CityName, listerProperty.State);
            return true;
        }
    }
}
