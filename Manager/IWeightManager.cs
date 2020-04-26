using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public interface IWeightManager
    {
        double KgToGram(double kg);

        double GramToKg(double gram);

    }
}
