using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.MementoPattern
{

    public interface Originator
    {
        RowMemento CreateRow();
        void SetRow(RowMemento rowMemento);

    }

    public class GridRow : Originator
    {

        public GridRow()
        {
            SetState();
        }

        private void SetState()
        {

            if (ReadOnly)
                State = "NoEdit";
            else
                State = "Edit";
        }


        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        private string State;

        private bool readOnly;
        public bool ReadOnly { get { return readOnly; } set { readOnly = value; SetState(); } }

        public RowMemento CreateRow(string property, string propertyValue, string state, bool isReadOnly)
        {
            return new RowMemento(property, propertyValue, state, isReadOnly);
        }

        public RowMemento CreateRow()
        {
            return new RowMemento(PropertyName, PropertyValue, State, ReadOnly);
        }

        public bool ValidateValues()
        {
            return true;
         //   throw new Exception();
        }


        public void SetRow(RowMemento rowMemento)
        {
            this.PropertyName = rowMemento.PropertyName;
            this.PropertyValue = rowMemento.PropertyValue;
            this.State = rowMemento.State;
            this.ReadOnly = rowMemento.ReadOnly;
        }
    }
}
