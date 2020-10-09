using System;
using System.Collections.Generic;
using System.Text;

namespace FileConsole
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
