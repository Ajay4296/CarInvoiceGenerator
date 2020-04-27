using System;
using System.Collections.Generic;
using System.Text;
using Repository;

namespace Manager
{
   public class WeightManager : IWeightManager
    {
        private readonly IWeightRepository repo;
        public WeightManager(IWeightRepository repo)
        {
            this.repo = repo;
        }
        public double KgToGram(double kg)
        {
            return this.repo.KgToGram(kg);

        }

       public  double GramToKg(double gram)
        {
            return this.repo.GramToKg(gram);
        }

    }
}
