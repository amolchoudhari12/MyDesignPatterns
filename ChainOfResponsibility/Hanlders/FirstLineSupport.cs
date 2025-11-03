using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility.Hanlders
{
    public class FirstLineSupport : AbstractSupport
    {
        public FirstLineSupport()
        {
            this.MinComplexity = 0;
            this.MaxComplexity = 5;
            this.SetSuccessorSupprtTeam(new SecondLineSupport());
        }     


    }
}
