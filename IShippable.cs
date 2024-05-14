using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public interface IShippable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
}
