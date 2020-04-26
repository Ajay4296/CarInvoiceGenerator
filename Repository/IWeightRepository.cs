using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface IWeightRepository
    {
        double GramToKg(double gm);
        double KgToGram(double kg);
       
    }
}
