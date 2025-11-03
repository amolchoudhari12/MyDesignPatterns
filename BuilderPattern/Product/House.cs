using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BuilderPattern
{
    public class House
    {
        public string Name { get; set; }
        public HouseType HouseType { get; set; }
        public double Area { get; set; }
        public double NoOfBedRooms { get; set; }
        public string Color { get; set; }
        public string Architecture { get; set; }

        public House(string name)
        {
            this.Name = name;         
        }

        public void ShowHouse()
        {
            Console.WriteLine("This is :{0}", Name);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("The Details About this house are below: ");
            Console.WriteLine("House Type :{0}\n", HouseType.ToString());
            Console.WriteLine("Area :{0}", Area.ToString());
            Console.WriteLine("NoOfBedRooms :{0}", NoOfBedRooms.ToString());
            Console.WriteLine("Color :{0}", Color);
            Console.WriteLine("Architecture :{0}", Architecture);
            Console.WriteLine("***********************************************");
        }
    }
}
