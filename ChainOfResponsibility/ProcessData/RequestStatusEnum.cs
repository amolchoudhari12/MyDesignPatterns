using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility
{
    public enum RequestStatusEnum
    {
        Initiated,
        Processing,
        Fixed,
        Completed
    }
}
