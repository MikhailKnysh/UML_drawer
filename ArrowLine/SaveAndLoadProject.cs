using System;
using System.IO;

namespace ArrowLine
{
    public static class SaveAndLoadProject
    {
        public static void SaveFile(string path, string fileData)
        {
            using (StreamWriter saveSW = new StreamWriter(path, false))
            {
                saveSW.WriteLine(fileData);
            }
        }

        public static string OpenFile(string path)
        {
            string fileData = String.Empty;
            using (StreamReader openSR = new StreamReader(path))
            {
                fileData = openSR.ReadToEnd();
            }

            return fileData;
        }
    }
}
