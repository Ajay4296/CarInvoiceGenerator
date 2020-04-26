using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public class TempManager : ITempManager
    {
        private readonly ITempRepository repo;
      public  double CelciusToFarenhite(double celcius)
        {
            return repo.CelciusToFarenhite(celcius);

        }

      public  double FarenhiteToCelcius(double Farenhite)
        {
            return repo.FarenhiteToCelcius(Farenhite);
        }
    }
}
