using System;
using System.Collections.Generic;
using System.Text;
using Repository;

namespace Manager
{
   public class WeightManager : IWeightManager
    {
        private readonly ITempRepository repo;
        public double KgToGram(double kg)
        {
            return repo.KgToGram(kg);

        }

       public  double GramToKg(double gram)
        {
            return repo.GramToKg(gram);
        }

    }
}
