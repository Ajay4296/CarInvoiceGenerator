using NUnit.Framework;
using CabInvoiceGenerator;
using System.Collections.Generic;
namespace TestCabInvoiceGenerator
{
    public class Tests
    {
        [Test]
        public void CalcaluateRidePrice()
        {
            InvoiceGenerator obj = new InvoiceGenerator();
            int distanceInKM = 11;
            int timeInMinute = 30;
            int Expected = (30 * 1) + (11 * 10);
            double Actual = obj.Calculator(distanceInKM, timeInMinute);
            Assert.AreEqual(Expected, Actual);
        }
        [Test]
        public void Total_Fare_of_Multiple_Ride()
        {
            double[] distanceInKm = { 3, 6, 7.5 };
            double[] timeInMinute = { 5, 18.5, 12 };
            InvoiceGenerator obj = new InvoiceGenerator();
            double Actual = obj.TotalFareCalculator(distanceInKm,timeInMinute);
            double Expected = 200.5;
            Assert.AreEqual(Actual, Expected);
        }
        [Test]
        public void Total_Number_of_Ride()
        {
            InvoiceGenerator obj = new InvoiceGenerator();
            double[] distanceInKm = { 3, 6, 7 };
            double Actual = obj.Number_of_Ride(distanceInKm);
            int Expected = distanceInKm.Length;
            Assert.AreEqual(Actual, Expected);
        }
        [Test]
        public void AverageFareOfTotalRide()
        {
            InvoiceGenerator obj = new InvoiceGenerator();
            double[] distanceInKm = { 3, 6, 7.5 };
            double[] timeInMinute = { 5, 18.5, 12 };
            double Actual = obj.AverageFareForEachRides(distanceInKm, timeInMinute);
            double Expected = 200.5 / 3;
            Assert.AreEqual(Actual, Expected);
        }
        [Test]
        public void get_Total_Fare_by_given_Id()
        {
            RideRepository rideRepository = new RideRepository();
            List<Ride> list =new List<Ride>();
            list.Add(new Ride(3, 5));
            list.Add(new Ride(6,18.5));
            list.Add(new Ride(7.5, 12));
            Customer New_Custmor = new Customer("Ajay@123456");
            rideRepository.AddRide(list, New_Custmor);
            InvoiceGenerator obj = new InvoiceGenerator();
            double actual = obj.GetInvoiceSummary(New_Custmor);
            double expected = obj.totalFare(list.ToArray());
            Assert.AreEqual(actual,expected);
        }
    }
}