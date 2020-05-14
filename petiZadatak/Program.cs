using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace petiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            fileLogger.SetNextLogger(logger);
            logger.SetNextLogger(null);

            fileLogger.Log("Test ALL ", MessageType.ALL);
            fileLogger.Log("Test ERROR ", MessageType.ERROR);
            fileLogger.Log("Test WARNING ", MessageType.WARNING);
            fileLogger.Log("Test INFO ", MessageType.INFO);
        }
    }
}
