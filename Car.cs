using System;
using System.Collections.Generic;
using System.Text;

namespace parking_assignment
{
  public class Car
    {
        public int hours;
        public float chargedFees = 2;
        public Car(int hours)
        {
            this.hours = hours;
        }

        public float calculateCharges()
        {
            if (hours == 24)
            {
                chargedFees += 10;
            }
            else if (hours > 3)
            {
                chargedFees += (float)(0.5 * ((float)this.hours - 3));
            }
            return chargedFees;
        }
    }
}
