using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    class TempratureManagment
    {
        public class Temperature
        {
            public double Celsius { get; set; }
            public Temperature(double Celsius)
            {
                this.Celsius = Celsius;
            }

            public bool CheckGmValue(double celsius)
            {
                if (this.Celsius == celsius)
                    return true;
                return false;
            }
            /*public double ConversionOfCelciusToFahrenhite(double f,double c)
            {
                double celcius = (f - 32) * (5 / 9);
                double fahrenhite = c * 1.8 + 32;
                if()
            }*/
        }
    }
}
