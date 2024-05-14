using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class DataConsolePrinter
    {
        
        public void Print(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();

            if (data == null)
            {
                Console.WriteLine("It contains nothing.");
            }

            else
            {
                foreach (List<string> outer in data)
                {
                    foreach (string inner in outer)
                    {
                        Console.Write(inner + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
