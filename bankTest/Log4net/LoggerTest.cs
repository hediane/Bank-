using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Layout;

namespace bankTest.Log4net
{
    public class LoggerTest
    {
       
       public static void writeLog(string message)
        {

            string pathLog = ConfigurationManager.AppSettings["pathLog"];
            using (StreamWriter writer = new StreamWriter(pathLog, true))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
    }
}
