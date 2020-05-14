using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace petiZadatak
{
    class FileLogger : AbstractLogger
    {
        private string filePath="logFile.txt";
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(message + type + DateTime.Now);
            }
        }
    }
}
