using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    public class Customer : IAcceptWorkingTerms
    {
        public Customer(string name, string proff, double registeredFee, bool isBillpayed)
        {
            this.CustomerName = name;
            this.Proffession = proff;
            this.RegisterdAmount = registeredFee;
            this.IsDefaulter = isBillpayed;
        }
        public string CustomerName { get; set; }
        public string Proffession { get; set; }
        public double RegisterdAmount { get; set; }
        public bool IsDefaulter { get; set; }

        public void AcceptWorkingTerms(IWork worker)
        {
            worker.Work(this);
        }
    }
}
