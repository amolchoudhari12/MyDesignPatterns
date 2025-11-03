using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.ChainOfResponsibility
{
    public abstract class AbstractSupport
    {
        protected int MinComplexity;
        protected int MaxComplexity;


        protected AbstractSupport SuccessorSupport;

        public void SetSuccessorSupprtTeam(AbstractSupport support)
        {
            this.SuccessorSupport = support;
        }

        public virtual void HandleRequest(SupportRequest request)
        {
            Console.WriteLine("Current Status of request's [{0}] is  {1} ", request.ID, Enum.GetName(typeof(RequestStatusEnum), request.Status));

            if (request.complexity < this.MaxComplexity)
            {
                request.Status = RequestStatusEnum.Fixed;
                Console.WriteLine("The request is processed by {0} ", this.GetType().Name);

            }
            else if (this.SuccessorSupport != null)
            {
                request.Status = RequestStatusEnum.Processing;
                Console.WriteLine("The request being passed to {0}  by {1} ", this.SuccessorSupport.GetType().Name, this.GetType().Name);
                this.SuccessorSupport.HandleRequest(request);
            }



        }

    }
}
