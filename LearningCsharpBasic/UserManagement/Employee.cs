namespace UserManagement
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Employee(string userid, string firstName, string lastName)
        {
            userid = userid;
            FirstName = firstName;
            LastName = lastName;
        }

        private string _fName;
        private string _lName;

        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }
    }
}