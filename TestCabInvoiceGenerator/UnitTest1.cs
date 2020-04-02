using NUnit.Framework;
using CabInvoiceGenerator;
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
    }
}