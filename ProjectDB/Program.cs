using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CustomersContext())
            {
                List<CustomerDetails> customerDetails = context.CustomerDetails.ToList();
                foreach (var customerDetailss in customerDetails)
                {
                    Console.WriteLine(customerDetailss.Address);
                }

            }
        }
    }
}
