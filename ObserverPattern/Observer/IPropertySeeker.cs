using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.ObserverPattern.Subject;

namespace MyDesignPatterns.ObserverPattern.Observer
{
    public interface IPropertySeeker
    {
        bool SendNotification(ListedProperty listerProperty);
    }
}
