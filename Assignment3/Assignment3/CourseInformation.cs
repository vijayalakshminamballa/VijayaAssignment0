using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class CourseInfo
    {
        string courseName;
        int credits;
        int durationInWeeks;
        string teacher;
        CourseInfo(string courseName, int credits, int durationInWeeks, String teacher)
        {
            this.courseName = courseName;
            this.credits = credits;
            this.durationInWeeks = durationInWeeks;
            this.teacher = teacher;
        }
        public static CourseInfo GetCourseInformation()
        {
            Console.WriteLine("Enter courseName");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter credits");
            int credits = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter durationInWeeks");
            int durationInWeeks = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher");
            string teacher = Console.ReadLine();
            CourseInfo course = new CourseInfo(courseName, credits, durationInWeeks, teacher);
            return course;
        }
        public void PrintCourseInformation()
        {
            Console.WriteLine("Course Information");
            Console.WriteLine("Course Name is {0}",this.courseName);
            Console.WriteLine("Number of credits is {0}",this.credits);
            Console.WriteLine("teacher is {0}", this.teacher);
        }
    }
}
