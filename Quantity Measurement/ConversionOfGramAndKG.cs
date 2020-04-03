using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
   public class ConversionOfGramAndKG
    {
        private readonly double gramm = 1000;
        public double gm { get; set; }
        public ConversionOfGramAndKG(double gm)
        {
            this.gm = gm;
        }

        public bool CheckGmValue(double Gm)
        {
            if (this.gm == Gm)
                return true;
            return false;
        }
        
        public bool Equalate_Kg_And_Gm(double Kg, double Gm)
        {
            if (Kg * this.gramm == Gm)
            {
                return true;
            }
            return false;
        }

    }
}
