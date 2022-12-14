using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Grocery
    {
        public string name;
        public double price;

        public Grocery(string name, double price) 
        {
            this.name = name;
            this.price = price;
        }
        public string GetName() 
        { return name; }
        public double GetPrice() 
        { return price; }
    }
}
