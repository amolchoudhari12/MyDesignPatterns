using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.MementoPattern
{

    public class RowMemento 
    {

        public RowMemento(string property, string propertyValue, string state, bool isReadOnly)
        {
            this.PropertyName = property;
            this.PropertyValue = propertyValue;
            this.State = state;
            this.ReadOnly = isReadOnly;
        }

        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public string State { get; set; }
        public bool ReadOnly { get; set; }
    }
}
