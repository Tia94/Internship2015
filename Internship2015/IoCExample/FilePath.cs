using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCExample
{
    class FilePath : IFilePath
    {
        public string Path { get; set; }

        public FilePath(string path)
        {
            Path = path;
        }
    }
}
