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
        public static void SkipLogic()
        {
            string str = "Skipped logic in method: SkipLogic";
            Logger.Instance.CreateLog(LogType.Warning, str);
            throw new BusinessException("Skipped logic in method");
        }
        public static void BrokeLogic()
        {
            string str = "I broke a logic";
            Logger.Instance.CreateLog(LogType.Error, str);
            throw new Exception("I broke a logic");
        }
    }
}
