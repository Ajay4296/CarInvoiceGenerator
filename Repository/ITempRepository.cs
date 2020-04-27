using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface ITempRepository
    {
        double CelciusToFarenhite(double celcius);
        double FarenhiteToCelcius(double fahrenheit);
        
    }
}
