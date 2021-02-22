using System;
using System.Collections.Generic;

namespace parking_assignment{
    public class Parking{
        public List<Car> list;

        public Parking(List<Car> list)
        {
            this.list = list;
        }

        public float calculateTotal()
        {
            float total = 0;
            foreach(var a in list)
            {
                Console.WriteLine(a);
                total += a.chargedFees;
            }
            return total;
        }
        
    }
}