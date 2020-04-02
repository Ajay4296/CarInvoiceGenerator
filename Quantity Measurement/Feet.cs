using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
   public class Feet
    {
        public bool EqualityCheck(int value)
        {
            if (value == 0)
                return true;
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return true;
            return false;
        }
    }
}
