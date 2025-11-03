using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility.Hanlders
{
   public class SecondLineSupport : AbstractSupport
    {

       public SecondLineSupport()
       {
           this.MinComplexity = 5;
           this.MaxComplexity = 8;
           this.SetSuccessorSupprtTeam(new ThirdLineSupport());
       }
      
     
    }
}
