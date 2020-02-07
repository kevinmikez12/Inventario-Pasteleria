using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Cliente
    {
        string name;
        string address;

        public Cliente()
        {
        }
        public Cliente(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return name;
        }
    }
}
