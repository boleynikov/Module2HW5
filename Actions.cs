using Module2HW5.Enum;
using Module2HW5.Exceptions;
using Module2HW5.Service;
using System;
namespace Module2HW5
{
    static class Actions
    {
        public static bool StartLogic()
        {
            string str = "Start Method: StartLogic";
            Logger.Instance.CreateLog(LogType.Info, str);
            return true;
        }
        public static Exception SkipLogic()
        {
            string str = "Skipped logic in method: SkipLogic";
            var exception = new BusinessException("Skipped logic in method");
            Logger.Instance.CreateLog(LogType.Warning, str);
            Logger.Instance.CreateLog(Enum.LogType.Warning, $"Action got this custom Exception: {exception.Message}");
            return exception;
        }
        public static void BrokeLogic()
        {
            string str = "I broke a logic";
            Logger.Instance.CreateLog(LogType.Error, str);
            throw new Exception("I broke a logic");
        }
    }
}
