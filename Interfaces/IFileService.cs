namespace Module2HW5.Interfaces
{
    public interface IFileService
    {
        Config Config { get; }
        void SaveFile(string content);
    }
}
