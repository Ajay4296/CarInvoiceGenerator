using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class ConversionOfQuantity
    {
        public bool ConvertFeetAndInch(double feet,double inch=0)
        {
            int inchResult = (int)(feet / 0.0833333333);
            int feetResult = (int)(inch * 0.084);
            if (inchResult == 12)
                return true;
            if (feetResult == 1)
                return true;
            if(inchResult==feetResult)
                return false;
            return true;
        }
        public double FeetToYArd(double feet,double yard=0)
        {
            int yardResult = (int)(feet * 0.334);
            int FeetResult = (int)(yard / 0.3333);
            if (FeetResult == 3)
                return FeetResult;
            if (yardResult == 1)
                return yardResult;
            return 0;
        }
        public bool Equality_of_Foot_and_Yard(double feet,double yard)
        {
            int FeetResult = (int)(yard / 0.34);
            int yardResult = (int)(feet * 0.3334);
            if (FeetResult == yardResult)
                return false;
            return true;
        }
        public double InchToYArd(int yard, int inch = 0)
        {
            int inchResult = (yard * 36);
            int yardResult = (inch / 36);
            if (yardResult == 1)
                return yardResult;
            if (inchResult == 36)
                return inchResult;
                return 0;
        }
    }
}

