using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    public class CoursePrinterSystem
    {
        // IEnumerable<T> is covariant (demonstrating variance)
        public static void PrintCourses(IEnumerable<CourseType> courses)
        {
            foreach (var c in courses)
            {
                c.DisplayCourseDetails();
            }
        }
    }
}