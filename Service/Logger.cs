using Module2HW5.Entities;
using Module2HW5.Enum;
using Module2HW5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module2HW5.Service
{
    class Logger 
    {
        private static List<Log> LogList = new List<Log>();
        private static Logger instance = null;
        private static readonly object padlock = new object();
        Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void CreateLog(LogType logType, string logMessage)
        {
            Log log = new Log(DateTime.Now, logType, logMessage);
            LogList.Add(log);
            Console.WriteLine(log.ToString());
        }

        public string GetLogListToString()
        {
            StringBuilder str = new StringBuilder(string.Empty);
            for (int i = 0; i < LogList.Count; i++)
            {
                str.AppendLine(LogList[i].ToString());
            }
            return str.ToString();
        }
    }
}
