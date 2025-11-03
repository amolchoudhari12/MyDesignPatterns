using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    public class FraudCustomer : Customer
    {
        public FraudCustomer()
            : base("Anil Kumawat", "worker", 50, false)
        {

        }

        public void MyMethod()
        {
            Console.WriteLine("I in my method");
        }
    }
}
