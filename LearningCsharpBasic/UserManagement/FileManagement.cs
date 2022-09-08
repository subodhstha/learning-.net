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
            File.WriteAllText(fileName, txtToWrite);
        }
    }
}
