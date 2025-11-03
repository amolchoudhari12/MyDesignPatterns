using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    /// <summary>
    /// Visitor
    /// </summary>
    public interface IWork
    {
        void Work(Customer customer);
       
    }
}
