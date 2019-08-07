using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName="VIJAYA";
            string studentLastName = "NUKA";
            DateTime studentBirthday = new DateTime(1995, 4, 30);
            string studentAddressLine1 = "4789 148th Ave";
            string studentAddressLine2 = "APT B101";
            string studentCity = "Bellevue";
            string studentState = "washington";
            string studentZipcode = "98007";
            string studentCountry = "USA";
            string teacherFirstName = "CHITTI";
            string teacherLastName = "NAMBALLA";
            DateTime teacherBirthday = new DateTime(1988, 10,25);
            string teacherAddressLine1 = "4785 142th Ave";
            string teacherAddressLine2 = "Lakes Apartment";
            string teacherCity = "seattle";
            string teacherState = "washington";
            string teacherZipcode = "98007";
            string teacherCountry = "USA";
            string programName = "software bootcamp";
            string departmentHead = "KALPANA";
            string[] degrees = new string[3] { "certificate course", "Masters","bachelors" };
            string degreeName = "Algorithms and data structures";
            int creditsRequired = 27;
            string courseName = "C#";
            int credits = 10;
            int durationInWeeks = 7;
            string teacher = "PRIYA";
            Console.WriteLine("Student Information");
            Console.WriteLine("First Name: {0}  Last Name: {1}",studentFirstName,studentLastName);
            Console.WriteLine("DateOfBirth: {0}",studentBirthday);
            Console.WriteLine("AddressLine: {0}  Addressline2: {1}", studentAddressLine1, studentAddressLine2);
            Console.WriteLine("City: {0}  State : {1}  Zipcode: {2} Country: {3}",studentCity,studentState,studentZipcode,studentCountry);
            Console.WriteLine(" ");
            Console.WriteLine("Teacher Information");
            Console.WriteLine("First Name:{0} Last Name: {1}",teacherFirstName,teacherLastName);
            Console.WriteLine("DateOfBirth: {0}",teacherBirthday);
            Console.WriteLine("AddressLine: {0}  Addressline2: {1}",teacherAddressLine1,teacherAddressLine2);
            Console.WriteLine("City: {0}  State : {1}  Zipcode: {2} Country: {3}", teacherCity, teacherState, teacherZipcode, teacherCountry);
            Console.WriteLine(" ");
            Console.WriteLine("UProgram Information");
            Console.WriteLine("Program Name: {0}  DepartmentHead: {1}",programName,departmentHead);
            Console.Write("Degrees: ");
            for (int i = 0; i < degrees.Length; i++)
            {

                Console.Write(degrees[i]);
                if ( degrees[i] != degrees[degrees.Length -1])
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Degree Information");
            Console.WriteLine("Degree Name: {0}  CreditsRequired: {1}",degreeName, creditsRequired);
            Console.WriteLine(" ");
            Console.WriteLine("Course Information");
            Console.WriteLine("Course Name: {0}  credits: {1} durationInWeeks: {2} Teacher: {3}",courseName,credits,durationInWeeks,teacher);




        }
    }
}
