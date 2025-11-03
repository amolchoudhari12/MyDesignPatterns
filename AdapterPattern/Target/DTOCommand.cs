using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public abstract class DTOCommand
    {
        public abstract void SendRequest(BACnetObjectIdentifierDTO bACnetObjectIdentifierDTO);
    }
}
