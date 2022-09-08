using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpBasic
{
    internal class FirstClass
    {
        private string _fName;
        private string _lName;
        
        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string LasrName
        {
            get { return _lName; }
            set { _lName = value; }
        }
    }
}

