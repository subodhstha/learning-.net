using System.IO;
using UserManagement;

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
        }
        private void SaveEmployee()
        {
            Employee objEmp = new Employee();
            objEmp.FirstName = txtFirstName.Text;
            objEmp.LastName = txtLastName.Text;

            //File.WriteAllText("OurlEmpData.txt", "First Name = " + objEmp.FirstName + " " + "Last Name = " + objEmp.LastName);
            string strFileName = "OurlEmpData1.txt";
            string strDataForFile = "First Name = " + objEmp.FirstName + " " + "Last Name = " + objEmp.LastName;
            FileManagement objFileManager = new FileManagement();
            objFileManager.SaveFile(strFileName, strDataForFile);
            MessageBox.Show("A file is stored in the BinFolder");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = String.Empty;
        }
    }
}