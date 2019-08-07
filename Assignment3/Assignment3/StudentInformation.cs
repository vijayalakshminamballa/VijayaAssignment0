using System;

public class Student
{
    string firstName;
    string lastName;
    DateTime birthday;
    string addressLine1; 
    string addressLine2;
    string city;
    string state;
    string zip;
    string country;
    Student(string firstName,string lastName,DateTime birthday,string addressLine1,string addressLine2,string city,string state,string zip,string country)
    {
       this.firstName = firstName;
       this.lastName = lastName;
        this.birthday = birthday;
       this.addressLine1 = addressLine1;
       this.addressLine2 = addressLine2;
       this.city = city;
       this.state = state;
       this.zip = zip;
       this.country = country;
    }
    public static  Student  GetStudentInformation()
	{
        Console.WriteLine("Enter the student's first name:");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter the student's last name:");
        string LastName = Console.ReadLine();
        Console.WriteLine("Enter the student's birthday");
        DateTime Birthday =DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the student's AddressLine1");
        string AddressLine1 = Console.ReadLine();
        Console.WriteLine("Enter the student's AddressLine2");
        string AddressLine2 = Console.ReadLine();
        Console.WriteLine("Enter the student's city");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the student's state");
        string state = Console.ReadLine();
        Console.WriteLine("Enter the student's zip");
        string zip = Console.ReadLine();
        Console.WriteLine("Enter the student's country");
        string country = Console.ReadLine();
        Student student = new Student(FirstName,LastName,Birthday,AddressLine1,AddressLine2,city,state,zip,country);
        return student;
     }
  

   // public static void GetStudentBirthday()
   // {
       // Console.WriteLine("Enter birthday");
       // DateTime birthday = DateTime.Parse(Console.ReadLine());

   // }
    public static void ValidatingStudentBirthday()
    {

        throw new NotImplementedException();
    }



    public void PrintStudentInformation()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("{0} {1} was born on :{2}",firstName, lastName, birthday);
        Console.WriteLine("Address is {0}, {1}, {2}, {3}, {4}, {5}", addressLine1, addressLine2,city,state,zip,country);
        
    }
}
 