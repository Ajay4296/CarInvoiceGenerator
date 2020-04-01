using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class CabRideCalculator
    {
        private static readonly int costPerMinute = 1;
        private static readonly double CostPerKm = 10;
        private static readonly double MINIMUM_FARE = 5;
        public double Calculator(int d,int t)
        {
            double result = (d * CostPerKm) + (t * costPerMinute);
            if(result<=5)
            return MINIMUM_FARE;
            return result;
        }
    }
}
