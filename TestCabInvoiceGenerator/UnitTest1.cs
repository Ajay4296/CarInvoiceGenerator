using NUnit.Framework;
using CabInvoiceGenerator;
namespace TestCabInvoiceGenerator
{
    public class Tests
    {
        [Test]
        public void CalcaluateRidePrice()
        {
            CabRideCalculator obj = new CabRideCalculator();
            int distanceInKM = 11;
            int timeInMinute = 30;
            int Expected = (30 * 1) + (11 * 10);
            double Actual = obj.Calculator(distanceInKM, timeInMinute);
            Assert.AreEqual(Expected, Actual);
        }
    }
}