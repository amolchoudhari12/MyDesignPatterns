using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    /// <summary>
    /// Element
    /// </summary>
    public interface IAcceptWorkingTerms
    {
        void AcceptWorkingTerms(IWork worker);
    }
}
