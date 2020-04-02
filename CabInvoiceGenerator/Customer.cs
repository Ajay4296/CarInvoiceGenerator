using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class Customer
    {
        public string User_id { get; set; }
        public Customer(string id)
        {
            this.User_id = id;
        }
    }
}
