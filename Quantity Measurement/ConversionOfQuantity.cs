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
                return true;
            return false;
        }
    }
}

