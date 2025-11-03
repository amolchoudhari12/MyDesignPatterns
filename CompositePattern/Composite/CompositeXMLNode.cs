using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CompositePattern
{
    public class CompositeXMLNode : XMLNodeComponent
    {
        public List<XMLNodeComponent> ListOfChilds = new List<XMLNodeComponent>();

        public CompositeXMLNode(int id, string name)
            : base(id, name)
        {
            base.ID = id;
            base.NodeName = name;
        }

        public override void Add(XMLNodeComponent node)
        {
            ListOfChilds.Add(node);
        }

        public override void Remove(XMLNodeComponent node)
        {
            ListOfChilds.Remove(node);
        }

        public override void Display(int id)
        {
            Console.WriteLine("Parent is : {0} ", NodeName);

            foreach (var item in ListOfChilds)
            {
                Console.WriteLine("Child is : {0} ", item.NodeName );
            }
        }
    }
}
