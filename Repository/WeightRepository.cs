using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public class WeightRepository : IWeightRepository
    {
        public double GramToKg(double gram)
        {
            return gram / 1000;
        }

        public double KgToGram(double kilogram)
        {
            return kilogram * 1000;
        }
    }
}
