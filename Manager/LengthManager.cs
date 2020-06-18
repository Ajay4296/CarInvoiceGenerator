using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
   public class LengthManager : ILengthManager
    {
        private readonly ILengthRepository repo;
        public LengthManager(ILengthRepository repo)
        {
            this.repo = repo;
        }
      public  double FeetToInche(double feet)
        {
            return this.repo.FeetToInche(feet);
        }
      public  double IncheToFeet(double inch)
        {
            return this.repo.IncheToFeet(inch);
        }
    }
}
