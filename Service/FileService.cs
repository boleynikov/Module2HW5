using Module2HW5.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Module2HW5.Service
{
     class FileService : IFileService
    {
        public Config Config { get; }
        public FileService(string pathToConfigFile)
        {
            var configFile = File.ReadAllText(pathToConfigFile);
            Config = JsonConvert.DeserializeObject<Config>(configFile);
        }
        public void SaveFile(string content)
        {
            if (Directory.Exists(Config.Directory))
            {
                var files = Directory.GetFiles($"{Config.Directory}");
                if (files.Length > 3)
                {
                    int latestTimeIndex = 0;
                    for(int i = 1; i < files.Length; i++)
                    {
                        if(File.GetCreationTime(files[i]) < File.GetCreationTime(files[i - 1]))
                        {
                            latestTimeIndex = i;
                        }
                    }
                    File.Delete(files[latestTimeIndex]);
                }
                File.WriteAllText($"{Config.Directory}/{DateTime.Now.ToString(Config.TimeFormat)}{Config.FileExtention}", content);
            }
            else
            { 
                throw new DirectoryNotFoundException();
            }
        }
    }
}
