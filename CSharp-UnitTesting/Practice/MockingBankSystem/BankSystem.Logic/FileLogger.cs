using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Logic
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("..\\..\\..\\log.txt", string.Format("[{2}] {0}.{1}", message, Environment.NewLine, DateTime.Now));
        }
    }
}
