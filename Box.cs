using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class Box : IShippable
    {
        private List<IShippable> items;
        private string name;
        public Box(string name)
        {
            this.items = new List<IShippable>();
            this.name = name;
        }
        public void Add(IShippable item)
        {
            this.items.Add(item);
        }
        public void Remove(IShippable item)
        {
            this.items.Remove(item);
        }
        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShippable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }

        public double Weight
        {
            get
            {
                double totalWeight = 0;
                foreach (IShippable item in items)
                {
                    totalWeight += item.Weight;
                }
                return totalWeight;
            }
        }

        public string Description(int depth = 0)
        {
            StringBuilder builder = new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShippable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
    }
}
