using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public class ReadProperty
    {
        public void SendRequest(ObjectIdentifier objectIdentifier)
        {
            Console.WriteLine("The Read proerty request has been sent on network for ID : {0}", objectIdentifier.ObjectType.ToString() + ", " + objectIdentifier.InstanceNumber.ToString());
        }
    }
}
