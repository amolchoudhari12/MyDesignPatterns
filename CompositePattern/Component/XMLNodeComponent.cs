using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CompositePattern
{
    public abstract class XMLNodeComponent
    {
        public int ID;
        public string NodeName;

        public XMLNodeComponent(int id, string name)
        {
            this.ID = id;
            this.NodeName = name;
        }

        public abstract void Add(XMLNodeComponent node);

        public abstract void Remove(XMLNodeComponent node);

        public abstract void Display(int id);
        
        
    }
}
