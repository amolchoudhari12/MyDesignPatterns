using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.ObserverPattern.Observer;

namespace MyDesignPatterns.ObserverPattern.Subject
{

    public enum PropertyState
    {
        Sold,
        Avilable,
        InDisscussion
    }
    public abstract class ListedProperty
    {

        public int BedRoom { get; set; }
        public double Price { get; set; }
        public string CityName { get; set; }

        public PropertyState State { get; set; }

        public virtual void AddProperty(int bedRoom, double price)
        {
            this.Price = price;
            this.BedRoom = bedRoom;
            this.State = PropertyState.Avilable;
            NotifyPropertySeeker();          
        }
      

        private List<IPropertySeeker> _listOfPropertySeeker = new List<IPropertySeeker>();

        public void Attach(IPropertySeeker propertySeeker)
        {
            _listOfPropertySeeker.Add(propertySeeker);
        }

        public void Dettach(IPropertySeeker propertySeeker)
        {
            _listOfPropertySeeker.Remove(propertySeeker);
        }

        public void NotifyPropertySeeker()
        {
            foreach (var item in _listOfPropertySeeker)
            {
                item.SendNotification(this);
            }
        }

    }
}
