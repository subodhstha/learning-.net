using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement;

namespace DataLayer
{
    public class EmployeeDataProvider
    {
        //public void AddEmp(string firstName, string lastName)
        string sqlConString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ToString();
        public void AddEmp(Employee objEmp)
        {

            try
            {
                //string ConString = "data source = SUBODH; database = UserManagement; integrated security = SSPI";
                using (SqlConnection connection = new SqlConnection(sqlConString))
                {
                    SqlCommand cmd =
                        new SqlCommand
                        //("insert into Employee values ('" + firstName + "', '" + lastName + "')", connection);
                        ("insert into Employee values ('" + objEmp.FirstName + "', '" + objEmp.LastName + "')", connection);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public void AddEmpBySP(Employee objEmp)
        {
            SqlConnection MySQLConnection = new SqlConnection(sqlConString);
            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = MySQLConnection;
            SQLCmd.CommandText = "[dbo].[uspEmpAdd]";
            SQLCmd.CommandType = CommandType.StoredProcedure;

            SQLCmd.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = objEmp.FirstName;
            SQLCmd.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = objEmp.LastName;
            try
            {
                MySQLConnection.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}
