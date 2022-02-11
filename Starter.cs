using Module2HW5.Exceptions;
using Module2HW5.Interfaces;
using Module2HW5.Service;
using System;
using System.Threading;

namespace Module2HW5
{
    class Starter
    {
        public static void Run()
        {
            int i = 0;
            Random rand = new Random();
            IFileService fileService = new FileService("config.json");

            while (i < 100)
            {
                try
                {
                    switch (rand.Next(1, 4))
                    {
                        case 1:
                            _ = Actions.StartLogic();
                            break;
                        case 2:
                            Actions.SkipLogic();
                            break;
                        case 3:
                            Actions.BrokeLogic();
                            break;
                    }
                }
                catch (BusinessException e)
                {
                    Logger.Instance.CreateLog(Enum.LogType.Warning, $"Action got this custom Exception: {e.Message}");
                }
                catch (Exception e)
                {
                    Logger.Instance.CreateLog(Enum.LogType.Error, $"Action failed by reason: {e}");
                }
                Thread.Sleep(30);
                i++;
            }
            fileService.SaveFile(Logger.Instance.GetLogListToString());
        }
    }
}
