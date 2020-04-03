using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
        public class Temperature
        {
            private readonly double cel = 33.8;
            public double Celsius { get; set; }
            public Temperature(double Celsius)
            {
                this.Celsius = Celsius;
            }

            public bool ChechTempreture(double celsius)
            {
                if (this.Celsius == celsius)
                    return true;
                return false;
            }
            public bool ConversionOfCelciusToFahrenhite(int c)
            {
               
               // double celcius = (f - 32) * (5 / 9);
                double fahrenhite = c * 1.8 + 32;
                if (fahrenhite == cel) 
                return true;
                return false;
            }
        }
    
}
