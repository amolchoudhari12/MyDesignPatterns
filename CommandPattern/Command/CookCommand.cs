using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public class CookCommand : Command
    {
        public CookCommand(Receiver cook): base(cook)
        {
                
        }
       
        public override void Execute()
        {
            this.Receiver.CookFood();
        }
    }
}
