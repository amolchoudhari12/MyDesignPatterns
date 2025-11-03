using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public abstract class Command
    {
        protected Receiver Receiver;

        public Command(Receiver cookReceiver)
        {
            this.Receiver = cookReceiver;
        }

        public abstract void Execute();       
    }
}
