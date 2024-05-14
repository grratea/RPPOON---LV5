using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class ShippingService
    {
        private double pricePerUnit;

        public ShippingService(double price) 
        {
            this.pricePerUnit = price;
        }

        public double CalculateShippingPrice(IShippable item)
        {
            return item.Weight * pricePerUnit;
        }
    }
}
