using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.PrototypePattern
{
    public class DropDownItem
    {
        public DropDownItem(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public DropDownItem(int id, int parentID, string name)
        {
            this.ID = id;
            this.ParentID = parentID;
            this.Name = name;
        }

        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
    }
}
