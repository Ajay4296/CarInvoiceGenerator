using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
  public class RideRepository
    {
        public static Dictionary<Customer, List<Ride>> RideDictionary = null;
        public RideRepository()
        {
            RideDictionary = new Dictionary<Customer, List<Ride>>();
        }

        public void AddRide(List<Ride> rides, Customer custmorId)
        {
            RideDictionary.Add(custmorId, rides);
        }
    }
}