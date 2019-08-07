using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
   public class Uprogram
    {
        string programName;
        string departmentHead;
        string degrees;
        Uprogram(string programName, string departmentHead,string degrees)
        {
            this.programName = programName;
            this.departmentHead = departmentHead;
            this.degrees = degrees;
            
        }
        public static Uprogram GetUprogramInformation()
        {
            Console.WriteLine("Enter Program Name");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter Department Head");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter degree");
            string degrees = Console.ReadLine();
            Uprogram uprogram = new Uprogram(programName, departmentHead, degrees);
            return uprogram;
        }
        public void PrintUprogramInformation()
        {
            Console.WriteLine("Uprogram Information");
            Console.WriteLine("Program Name is {0}", this.programName);
            Console.WriteLine("Department Head is {0}", this.departmentHead);
            Console.WriteLine("Degrees: {0} ", this.degrees);

        }


    }
}
