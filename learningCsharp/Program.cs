// See https://aka.ms/new-console-template for more information
using System.Text;
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Please enter your First name");
//string firstName = Console.ReadLine();

//Console.WriteLine("Please enter your Lasr name");
//string lastName = Console.ReadLine();

//Console.WriteLine("Your Name is " + firstName + " " + lastName);

string str1 = "";
string str2 = string.Empty;


FirstClass objFirst = new FirstClass();
Console.WriteLine("Please enter your First name");
objFirst.firstName = Console.ReadLine();
Console.WriteLine("Please enter your address");
objFirst.Address = Console.ReadLine();
Console.WriteLine("Your Name is " + objFirst.firstName + " address is " + objFirst.Address);



/// <summary>
/// this is class 
/// </summary>
public class FirstClass
{
    public string firstName { get; set; }

    public string Address { get; set; }

    public string GetUserDetails()
    {
        StringBuilder strDetail = new StringBuilder();
        strDetail.Append("Name = ");
        strDetail.Append(firstName);
        strDetail.Append(" ");
        strDetail.Append("Address = ");
        strDetail.Append(Address);
        return strDetail.ToString();
    }
}

//public class FirstClass
//{
//    public string firstName { get; set; } = "John";

//    public string Adress { get; set; } = "Kathmandu";

//    public string GetUserDetails()
//    {
//        return "Name " + firstName + " address is " +  Address;
//    }
//}


//int ageEmp;
//int ageCar;
//ageCar = 0;
//string nameOfManager = "abc"