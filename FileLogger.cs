using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class FileLogger
    {

        private static FileLogger instance;
        private string filePath;
        private FileLogger() 
        {
            this.filePath = "C:\\Users\\student\\source\\repos\\RPPOON - LV5\\log.txt";
        }
        public static FileLogger GetInstance()
        {
            if (instance == null) 
            { 
                instance = new FileLogger();
            }

            return instance;
        }

        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public void LogMessage(string message) 
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}"); 
            }
        }
    }
}
