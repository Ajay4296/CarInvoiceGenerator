using NUnit.Framework;
using Quantity_Measurement;
namespace Quantity_Measurement_Test
{
    public class ConvertFeetToInch
    { 
        [Test]
        public void Check_Equlity_Test()
        {
            Quantity feet = new Quantity(0);
           bool Expected= feet.EqualityCheck(0);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Null_Test()
        {
            Quantity feet = new Quantity(0);
            bool Expected = feet.Equals(null);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Reference_Test()
        {
            Quantity feet = new Quantity(0);
            bool Expected = feet.Equals(feet);
            Assert.AreEqual(Expected,true);
        }
        [Test]
        public void Check_Type_()
        {
            Quantity feet = new Quantity(0);
            bool Expected = feet.Equals(feet);
            Assert.AreEqual(Expected, true);
        }
        
        [Test]
        public void Test_Feet_Value()
        {
            Quantity feet = new Quantity(10);
            Assert.AreEqual(feet.EqualityCheck(10), true);
        }

        [Test]
        public void Test_Feet_Value1()
        {
            Quantity feet = new Quantity(5.5);
            Assert.AreEqual(feet.EqualityCheck(5.5), true);
        }
        [Test]
        public void Check_Equlity_Inch()
        {
            Quantity inch = new Quantity(0);
            bool Expected = inch.EqualityCheck(0);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Null_Inch_value()
        {
            Quantity inch = new Quantity(0);
            bool Expected = inch.Equals(null);
            Assert.IsTrue(Expected);
        }
        [Test]
        public void Check_Reference_of_quantity()
        {
            Quantity inch = new Quantity(0);
            bool Expected = inch.Equals(inch);
            Assert.AreEqual(Expected, true);
        }
        [Test]
        public void Check_Type_of_Quantity()
        {
            Quantity inch = new Quantity(0);
            bool Expected = inch.Equals(inch);
            Assert.AreEqual(Expected, true);
        }

        [Test]
        public void Test_Feet_Value_int()
        {
            Quantity inch = new Quantity(10);
            Assert.AreEqual(inch.EqualityInchCheck(10), true);
        }

        [Test]
        public void Test_Feet_Value1_double ()
        {
            Quantity inch = new Quantity(5.5);
            Assert.AreEqual(inch.EqualityInchCheck(5.5), true);
        }
        [Test]
        public void ConvertFitAndInch()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int feet = 0;
            int inch = 0;
            bool Actual = obj.ConvertFeetAndInch(feet, inch);
            Assert.AreEqual(Actual, false);
        }
        [Test]
        public void ConvertFitAndInch1()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int feet = 1;
            int inch = 1;
            bool Actual = obj.ConvertFeetAndInch(feet, inch);
            Assert.AreEqual(Actual,true);
        }
        [Test]
        public void ConvertFeetToInch1()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int feet = 1;
            bool Actual = obj.ConvertFeetAndInch(feet);
            Assert.AreEqual(Actual, true);
        }
        [Test]
        public void ConvertInchToFeet1()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int feet = 0;
            int inch = 12;
            bool Actual = obj.ConvertFeetAndInch(feet,inch);
            Assert.AreEqual(Actual, true);
        }
        [Test]
        public void Feet_To_Yard_Conversion_check()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int feet = 3;
            Assert.AreEqual(obj.FeetToYArd(feet), 1);
        }
        [Test]
        public void CHeckEqualityOfYArdAndInch()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int yard = 1;
            int feet = 1;
            bool Actual = obj.Equality_of_Foot_and_Yard(feet, yard);
            Assert.AreEqual(Actual, true);
        }
        [Test]
        public void Inch_To_Yard_Conversion_check()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int Yard = 1;
            Assert.AreEqual(obj.InchToYArd(Yard), 36);
        }
        [Test]
        public void Inch_To_Yard_Conversion_check2()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int inch = 36;
            int yard = 1;
            Assert.AreEqual(obj.InchToYArd(yard,inch), yard);
        }
        [Test]
        public void yard_To_feet_Conversion_check()
        {
            ConversionOfQuantity obj = new ConversionOfQuantity();
            int yard = 1;
            int feet = 3;
            Assert.AreEqual(obj.FeetToYArd(feet,yard), feet);
        }
    }
}