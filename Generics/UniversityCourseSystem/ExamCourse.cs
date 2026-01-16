using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    public class ExamCourse : CourseType
    {
        // passing values to parent class using base keyword
        public ExamCourse(string Name, int duration) : base(Name, duration)
        {
            Type = "Exam"; // coursetype initializing
        }
        // overriding base class method
        public override void DisplayCourseDetails()
        {
            System.Console.WriteLine($"Course Name: {Name} | Course Duration: {DurationInMonths} months | Course Type: {Type}");
        }
    }
}