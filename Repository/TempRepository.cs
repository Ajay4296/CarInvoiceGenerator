using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public class TempRepository : ITempRepository
    {
        public double CelciusToFarenhite(double celcius)
        {
            double result = (celcius * 9 / 5) + 32;
            return result;
        }

        public double FarenhiteToCelcius(double fahrenhit)
        {
           double result = (fahrenhit - 32) * 5 / 9;
            return result;
        }
    }
}
