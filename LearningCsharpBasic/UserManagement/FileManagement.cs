using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class FileManagement
    {
        public void SaveFile(string fileName, string txtToWrite)
        {
            //string str = GetFilePath() + fileName;
            //File.WriteAllText(str, txtToWrite);
            string strFilenameWithPath = GetFilePath();
            if(!Directory.Exists(strFilenameWithPath))
            {
                Directory.CreateDirectory(strFilenameWithPath);
            }
            strFilenameWithPath += fileName;
            File.WriteAllText(strFilenameWithPath, txtToWrite);
        }
        public string GetFilePath()
        {
            //string str = @".\\myfiles\";
            string str = @".\myfiles\";
            return str;
        }
    }
}
