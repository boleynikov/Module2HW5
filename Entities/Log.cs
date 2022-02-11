using Module2HW5.Enum;
using System;

namespace Module2HW5.Entities
{
    class Log
    {
        public DateTime Time { get; private set; }
        public LogType LogType { get; private set; }
        public string LogMessage { get; private set; }


        public Log(DateTime time, LogType logType, string message)
        {
            Time = time;
            LogType = logType;
            LogMessage = message;
        }

        public override string ToString()
        {
            return $"{Time.ToLongTimeString()}: {LogType}: {LogMessage}";
        }
    }
}
