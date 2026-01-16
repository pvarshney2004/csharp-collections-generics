using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    // generic class
    public class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>(); // list to store diffrent type of courses

        public void AddCourse(T course)
        {
            courses.Add(course);
        }
        public List<T> GetAllCourses()
        {
            return courses;
        }
        public void Display()
        {
            foreach (T course in courses)
            {
                course.DisplayCourseDetails(); // Polymorphism demonstration
            }
        }
    }
}