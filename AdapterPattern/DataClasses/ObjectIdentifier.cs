using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public enum ObjectType
    {
        Device,
        AnalogInput,
        AnalogOutput,
        AnalogValue
    }


    public class ObjectIdentifier
    {
        public ObjectType ObjectType { get; set; }
        public uint InstanceNumber { get; set; }
    }
}
