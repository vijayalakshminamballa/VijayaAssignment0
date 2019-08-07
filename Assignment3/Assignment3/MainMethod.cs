using System;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
           try
            {
                Student student = Student.GetStudentInformation();
                student.PrintStudentInformation();
                Student.ValidatingStudentBirthday();
              
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("The data you entered is incorrect format");
            }
            Teacher teacher = Teacher.GetTeacherInformation();
            teacher.PrintTeacherInformation();
            Uprogram uprogram = Uprogram.GetUprogramInformation();
            uprogram.PrintUprogramInformation();
            DegreeInfo degree = DegreeInfo.GetDegreeInformation();
            degree.PrintDegreeInformation();
            CourseInfo course = CourseInfo.GetCourseInformation();
            course.PrintCourseInformation();


        }
    }
}
