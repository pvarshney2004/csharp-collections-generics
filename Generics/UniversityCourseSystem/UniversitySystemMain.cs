using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    /*
    3. Multi-Level University Course Management System
o Concepts: Generic Classes, Constraints, Variance
o Problem Statement: Develop a university course management
system where different departments offer courses with different
evaluation types.
o Hints:
▪ Create an abstract class CourseType (e.g., ExamCourse,
AssignmentCourse).
▪ Implement a generic class Course<T> where T : CourseType
to manage different courses.
▪ Use List<T> to handle any type of course dynamically
    */
    public class UniversitySystemMain
    {
        public static void Execute()
        {
            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
            assignmentCourses.AddCourse(new AssignmentCourse("DBMS",4));
            assignmentCourses.AddCourse(new AssignmentCourse("DSA",5));
            System.Console.WriteLine("Assignment Courses Details: ");
            assignmentCourses.Display();

            Course<ExamCourse> examCourses = new Course<ExamCourse>();
            examCourses.AddCourse(new ExamCourse("OS",7));
            examCourses.AddCourse(new ExamCourse("C#",8));
            System.Console.WriteLine("\nExam Courses Details: ");
            examCourses.Display();

            Console.WriteLine("\nUsing Variance:");
            CoursePrinterSystem.PrintCourses(assignmentCourses.GetAllCourses());
            CoursePrinterSystem.PrintCourses(examCourses.GetAllCourses());
        }
    }
}