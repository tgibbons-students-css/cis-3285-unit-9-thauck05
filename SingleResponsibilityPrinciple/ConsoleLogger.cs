using System;
using System.IO;
using SingleResponsibilityPrinciple.Contracts;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><message>" + message + "</message></log> ", args);
            }
        }

        void ILogger.LogInfo(string message, params object[] args)
        {
            Console.WriteLine(message, args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><message>" + message + "</message></log> ", args);
            }
        }        
    }
}
