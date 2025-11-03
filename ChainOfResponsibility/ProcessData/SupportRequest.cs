using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility
{
    public class SupportRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int complexity { get; set; }
        public RequestStatusEnum Status { get; set; }
    }
}
