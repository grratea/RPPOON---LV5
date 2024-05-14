using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class Product : IShippable
    {
        private double price;
        private string description;
        private double weight;
        public Product(string description, double price, double weight)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return this.price; } }

        public double Weight {  get { return this.weight; } }

        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }

}
