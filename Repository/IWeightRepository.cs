using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface IWeightRepository
    {
        double KgToGram(double kg);
        double GramToKg(double gm);
        
       
    }
}