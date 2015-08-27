
namespace IoCExample
{
    public class FilePath : IFilePath
    {
        public string Path { get; set; }

        public FilePath(string path)
        {
            Path = path;
        }
    }
}
