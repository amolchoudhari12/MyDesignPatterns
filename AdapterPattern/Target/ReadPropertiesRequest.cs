using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public class ReadPropertiesRequest : DTOCommand
    {
        public override void SendRequest(BACnetObjectIdentifierDTO bACnetObjectIdentifierDTO)
        {
            RequestManagerAdapter client = new RequestManagerAdapter();
            client.SendRequest(bACnetObjectIdentifierDTO);
        }
    }
}
