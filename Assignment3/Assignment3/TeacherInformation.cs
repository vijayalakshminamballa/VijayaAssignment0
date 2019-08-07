using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Teacher
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
        Teacher(string firstName, string lastName, DateTime birthday, string addressLine1, string addressLine2, string city, string state, string zip, string country)
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
        public static Teacher GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday");
            DateTime Birthday =DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Enter the teacher's AddressLine1");
            string AddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's AddressLine2");
            string AddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the teacher's zip");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter the teacher's country");
            string country = Console.ReadLine();
            Teacher teacher = new Teacher(FirstName, LastName, Birthday, AddressLine1, AddressLine2, city, state, zip, country);
            return teacher;
        }

        public void PrintTeacherInformation()
        {
            Console.WriteLine("Teacher Information");
            Console.WriteLine("{0} {1} was born on :{2}", firstName, lastName, birthday);
            Console.WriteLine("Address is {0}, {1}, {2}, {3}, {4}, {5}", addressLine1, addressLine2, city, state, zip, country);

        }
    }

}

