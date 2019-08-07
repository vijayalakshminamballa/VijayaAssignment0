using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
   public class DegreeInfo
    {
        string degreeName;
        int creditsRequired;
    DegreeInfo(string degreeName,int creditsRequired)
        {
            this.degreeName = degreeName;
            this.creditsRequired = creditsRequired;
        }
 public static DegreeInfo GetDegreeInformation()
     {
            Console.WriteLine("Enter the Degree Name");
            string DegreeName = Console.ReadLine();
            Console.WriteLine("Enter the credits Required");
            int CreditsRequired = Int32.Parse(Console.ReadLine());
            DegreeInfo degree = new DegreeInfo(DegreeName,CreditsRequired);
            return degree;
        }
        public void PrintDegreeInformation()
        {
            Console.WriteLine("Degree Information");
            Console.WriteLine("Degree Name is {0}", this.degreeName);
            Console.WriteLine("Credits required is {0}", this.creditsRequired);
        }


    }
}
