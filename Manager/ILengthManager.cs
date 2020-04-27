using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public interface ILengthManager
    {
       double FeetToInche(double feet);

       double IncheToFeet(double inch);
    }
}
