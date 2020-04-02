using NUnit.Framework;
using Quantity_Measurement;
namespace Quantity_Measurement_Test
{
    public class ConvertFeetToInch
    { 
        [Test]
        public void Check_Equlity_Test()
        {
            Feet feet = new Feet();
           bool Expected= feet.EqualityCheck(0);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Null_Test()
        {
            Feet feet = new Feet();
            bool Expected = feet.Equals(null);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Reference_Test()
        {
            Feet feet = new Feet();
            bool Expected = feet.Equals(feet);
            Assert.AreEqual(Expected,true);
        }
        [Test]
        public void Check_Type_()
        {
            Feet feet = new Feet();
            bool Expected = feet.Equals(feet);
            Assert.AreEqual(Expected, true);
        }
    }
}