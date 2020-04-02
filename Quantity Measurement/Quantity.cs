using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
   public class Quantity
    {
        public double value { get; set; }
        public Quantity(double value)
        {
            this.value = value;
        }
        public bool EqualityCheck(double value)
        {
            if (this.value == value)
                return true;
            return false;
        }
        public bool EqualityInchCheck(double value)
        {
            if (this.value == value)
                return true;
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType().Equals(obj.GetType()))
                return true;
            return false;
        }
       
    }
}
