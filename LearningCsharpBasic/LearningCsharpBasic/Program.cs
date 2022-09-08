//// See https://aka.ms/new-console-template for more information
//using System.Text;
////Console.WriteLine("Hello, World!");


////Console.WriteLine("Enter Your first name ");
////string firstName = Console.ReadLine();
////Console.WriteLine("Enter your last name ");
////string lastName = Console.ReadLine();

////Console.WriteLine("Your name is " + firstName + " " +lastName);






//////this is the object

////FirstClass objFirst = new FirstClass();

//////objFirst.FirstName = "John";
//////objFirst.FirstName = "John";

////FirstClass objFirst1 = new FirstClass();



////Console.WriteLine(objFirst.FirstName);
/////// <summary>
/////// This is class
/////// </summary>
////public class FirstClass
////{
////    public string FirstName { get; set; } = "Tom";
////    public string Address { get; set; } = "New York";
////}



//FirstClass objFirst = new FirstClass();
//Console.WriteLine("Please enter your First name");
//objFirst.firstName = Console.ReadLine();
//Console.WriteLine("Please enter your address");
//objFirst.Address = Console.ReadLine();
//Console.WriteLine("Your Name is " + objFirst.firstName + " address is " + objFirst.Address);



///// <summary>
///// this is class 
///// </summary>
//public class FirstClass
//{
//    public string firstName { get; set; }

//    public string Address { get; set; }

//    public string GetUserDetails()
//    {
//        StringBuilder strDetail = new StringBuilder();
//        strDetail.Append("Name = ");
//        strDetail.Append(firstName);
//        strDetail.Append(" ");
//        strDetail.Append("Address = ");
//        strDetail.Append(Address);
//        return strDetail.ToString();
//    }
//}



//day3
using UserManagement;
Employee obj = new Employee("john", "mikal");
Console.WriteLine(obj.FirstName + " " + obj.LastName);

Employee obj1 = new Employee("abc", "def");
Console.WriteLine(obj1.FirstName + " " + obj1.LastName);

Console.WriteLine("No. of uesr = "  + UserSetting.noOfUser);
Console.WriteLine("Application's Name = "  + UserSetting.applicationName);