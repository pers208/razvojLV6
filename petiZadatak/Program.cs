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
            StreamWriter streamWriter = new StreamWriter("logfile.txt");
            logger.Log("404",MessageType.ERROR);
            logger.Log("how you doin", MessageType.INFO);
            logger.Log("keep your distance!", MessageType.WARNING);
        }
    }
}
