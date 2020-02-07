using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Pastel
    {
        double price, cost;
        string name;

        public Pastel()
        {
        }
        public Pastel(double price, double cost , string name)
        {
            this.price = price;
            this.cost = cost;
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }
        public double getCost()
        {
            return cost;
        }
        public string getName()
        {
            return name;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setCost(double cost)
        {
            this.cost = cost;
        }
        public void setName(string name)
        {
            this.name = name;
        }
 
    }
}
