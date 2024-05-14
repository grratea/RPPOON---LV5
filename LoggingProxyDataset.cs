using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private FileLogger logger;

        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
            logger = FileLogger.GetInstance();
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }

        public void LogMessage(string message) 
        {
            logger.LogMessage(message);
        }

    }
}
