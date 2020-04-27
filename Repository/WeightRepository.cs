using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public class WeightRepository : IWeightRepository
    {
        public double KgToGram(double kg)
        {
            return kg * 1000;
        }
        public double GramToKg(double gm)
        {
            return gm / 1000;
        }

       
    }
}
