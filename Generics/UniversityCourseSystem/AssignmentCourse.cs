using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    public class AssignmentCourse : CourseType
    {
        // passing values to parent class using base keyword
        public AssignmentCourse(string Name, int duration) : base(Name, duration)
        {
            Type = "Assignment"; // coursetype initializing
        }
        // overriding base class method
        public override void DisplayCourseDetails()
        {
            System.Console.WriteLine($"Course Name: {Name} | Course Duration: {DurationInMonths} months | Course Type: {Type}");
        }
    }
}