using System.IO;
using UserManagement;
using DataLayer;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee("john", "mikal");
            MessageBox.Show(obj.FirstName + " " + obj.LastName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEmployee();
            ClearForm();
            BindDataGrid();
        }
        private void SaveEmployee()
        {
            Employee objEmp = new Employee();
            objEmp.FirstName = txtFirstName.Text;
            objEmp.LastName = txtLastName.Text;

            //File.WriteAllText("OurlEmpData.txt", "First Name = " + objEmp.FirstName + " " + "Last Name = " + objEmp.LastName);
            string strFileName = "OurlEmpData1.txt";
            string strDataForFile = "First Name = " + objEmp.FirstName + " " + "Last Name = " + objEmp.LastName;
            
            //FileManagement objFileManager = new FileManagement();
            //objFileManager.SaveFile(strFileName, strDataForFile)
            //MessageBox.Show("A file is stored in the BinFolder");

            EmployeeDataProvider objData = new EmployeeDataProvider();
            //objData.AddEmp(objEmp.FirstName, objEmp.LastName);
            //objData.AddEmp(objEmp);
            if (userID == 0)
            {
                objData.AddEmpBySP(objEmp);
            }
            else
            {
                objEmp.UserId = userID;
                objData.UpdateEmpBySP(objEmp);
                userID = 0;
            }
            MessageBox.Show("A file is stored in Database");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = String.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        public void BindDataGrid()
        {
            EmployeeDataProvider objData = new EmployeeDataProvider();
            DataTable dt = objData.GetAllEmp();
            dataGridView1.DataSource = dt;
            //dataGridView1.DataMember = "Authors_table";
        }

        int userID = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (userID != 0)
            {
                LoadUserDataByID();
            }
        }
        public void LoadUserDataByID()
        {
            EmployeeDataProvider objEmpData = new EmployeeDataProvider();
            DataTable dt = objEmpData.GetEmpByUserID(userID);
            Employee obj = new Employee();
            if(dt != null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    txtFirstName.Text = dr[1].ToString();
                    txtLastName.Text = dr[2].ToString();
                }
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    DataRow dr = dt.Rows[i];
                //    txtFirstName.Text = dr[0].ToString();
                //    txtLastName.Text = dr[2].ToString();
                //}
            }
        }

        //private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show(e.RowIndex.ToString());
        //}
    }
}