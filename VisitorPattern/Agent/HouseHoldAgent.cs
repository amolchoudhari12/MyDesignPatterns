using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.VisitorPattern
{
    public class HouseHoldAgent
    {
        List<Customer> _customerList = new List<Customer>();


        public void Attach(Customer customer)
        {
            _customerList.Add(customer);

        }

        public void Dettach(Customer customer)
        {
            _customerList.Remove(customer);
        }

        public void StartWork(IWork work)
        {
            //if (_customerList.Where(v => v.CustomerName == "Anil Kumawat").OrderBy(v => v.CustomerName).Any(v => v.IsDefaulter == true))                
            foreach (var item in _customerList)
            {
                item.AcceptWorkingTerms(work);
            }
        }
    }
}
