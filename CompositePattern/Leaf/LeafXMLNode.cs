using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CompositePattern
{
    public class LeafXMLNode : XMLNodeComponent
    {
        public LeafXMLNode(int id, string name) : base(id,name)
        {
            base.ID = id;
            base.NodeName = name;
        }
        public override void Add(XMLNodeComponent node)
        {
            Console.WriteLine("Can not add to leaf node");
        }

        public override void Remove(XMLNodeComponent node)
        {
            Console.WriteLine("Can not remove from leaf node");
        }

        public override void Display(int id)
        {
            Console.WriteLine("Current node is : {0}", NodeName);
        }
    }
}
