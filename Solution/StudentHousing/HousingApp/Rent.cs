using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Rent
    {
        private double rent;
        public Rent(double rent)
        {
            this.rent = rent;
        }

        public double GetRent()
        { return rent; }
    }
}
