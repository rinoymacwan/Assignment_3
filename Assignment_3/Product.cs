using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Product
    {
        public string Name, Type;
        public double Price;
        public int Quantity;

        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public override string ToString()
        {
            return $"Name: {Name} Rs.{Price} Quantity: {Quantity} Type: {Type}";
        }
    }
}
