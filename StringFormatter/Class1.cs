using System;
using System.IO;
using System.Text;

namespace StringFormatterApp
{
    public class StringFormatter
    {
        public StringFormatter()
        {

        }

        public string ShortFileString(string path)
        {
            if (path == string.Empty)
                return path;
            if (path == null)
                throw new NullReferenceException();
            return Path.GetFileNameWithoutExtension(path).ToUpper() + ".TMP";
        }
    }
}