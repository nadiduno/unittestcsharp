using System;
using System.IO;

namespace MyClass
{
    public class FileProcess 
    {
        public bool FileExistes(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("filename");
            return File.Exists(filename);
        }
    }
}
