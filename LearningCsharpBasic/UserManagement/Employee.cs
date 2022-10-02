namespace UserManagement
{
    public interface IEmployee 
    { 
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Employee: IEmployee
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
        public Employee(string userid, string firstName, string lastName, string gender)
        {
            userid = userid;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
        public int UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        private string Gender { get; set; }
        public string GetGender()
        {
            return Gender;
        }
    }
    public class Manager: Employee
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
    public interface IShape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Area();
    }
    public class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Area()
        { 
            return Length * Breadth;
        }
    }
    public class Square : IShape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Area()
        {
            return Length * Length;
        }
    }
}