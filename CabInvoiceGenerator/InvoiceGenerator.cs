using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class InvoiceGenerator
    {
        private static readonly int costPerMinute = 1;
        private static readonly int CostPerKm = 10;
        private static readonly int MINIMUM_FARE = 5;
        double distanceFare=0;
        double timefare=0;
        public double Calculator(int d,int t)
        {
            double  result = (d * CostPerKm) + (t * costPerMinute);
            if(result<=5)
            return MINIMUM_FARE;
            return result;
        }
        public double TotalFareCalculator(double[] distance,double[] time)
        {

            foreach (double dist in distance)
            {
                 distanceFare = distanceFare+(dist * CostPerKm);
            }
            foreach(double timeInMin in time)
            {
                 timefare = timefare +(costPerMinute * timeInMin);
            }
            return distanceFare + timefare;
        }
        public int Number_of_Ride(double[] distance )
        {
            return distance.Length;
        }
        public double AverageFareForEachRides(double[] distanceInKm,double[] timeInMinute)
        {
           InvoiceGenerator obj = new InvoiceGenerator();
            double Totalfare = obj.TotalFareCalculator(distanceInKm,timeInMinute);
            double NoOfRides = obj.Number_of_Ride(distanceInKm);
            double AvgFare = Totalfare / NoOfRides;
            return AvgFare;
        }


    }

}
