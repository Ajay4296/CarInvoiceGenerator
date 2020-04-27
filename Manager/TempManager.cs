using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public class TempManager : ITempManager
    {
        private readonly ITempRepository repo;
        public TempManager(ITempRepository repo)
        {
            this.repo = repo;
        }
        public  double CelciusToFarenhite(double celcius)
        {
            return this.repo.CelciusToFarenhite(celcius);

        }

      public  double FarenhiteToCelcius(double Farenhite)
        {
            return this.repo.FarenhiteToCelcius(Farenhite);
        }
    }
}
