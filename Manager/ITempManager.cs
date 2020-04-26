using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public interface ITempManager
    {
        double CelciusToFarenhite(double celcius);

        double FarenhiteToCelcius(double Farenhite);
    }
}
