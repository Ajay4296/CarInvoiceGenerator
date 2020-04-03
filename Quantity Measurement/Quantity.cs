using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
   public class Quantity
    {
        /// <summary>
        /// automatic proparty of get set
        /// </summary>
        public double value { get; set; }
        /// <summary>
        /// constructer for intialization
        /// </summary>
        /// <param name="value"></param>
        public Quantity(double value)
        {
            this.value = value;
        }
        /// <summary>
        /// Equality check
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool EqualityCheck(double value)
        {
            if (this.value == value)
                return true;
            return false;
        }
        
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool EqualityInchCheck(double value)
        {
            if (this.value == value)
                return true;
            return false;
        }
        /// <summary>
        /// ovrRideOfBoolean
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType().Equals(obj.GetType()))
                return true;
            return false;
        }
       
    }
}
