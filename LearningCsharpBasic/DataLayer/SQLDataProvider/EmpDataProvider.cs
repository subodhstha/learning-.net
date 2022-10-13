using LogicLayer.SQLHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement;

namespace DataLayer.SQLDataProvider
{
    /// <summary>
    /// This method is used for adding emp in the database
    /// </summary>
    /// <param name="objEmp">Please Pass the emp object with first name and last name</param>
    public class EmpDataProvider
    {
        public void AddEmp(Employee objEmp)
        {
            SQLHandler objSQLH = new SQLHandler();

            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@FirstName", objEmp.FirstName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@LastName", objEmp.LastName));
            objSQLH.ExecuteNonQuery("[dbo].[uspEmpAdd]", ParaMeterCollection);
        }
    }
}
