using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.UniversityCourseSystem
{
    // abstract base class
    public abstract class CourseType
    {
        public string? Name;
        // private data member for demonstrating encapsulation
        private int durationInMonths; 
        // public getter and setter for private data member
        public int DurationInMonths
        {
            get => durationInMonths;
            set
            {
                if (value < 3)
                {
                    Console.WriteLine("Course duration should be 3 or more months.");
                    return;
                }
                durationInMonths = value;
            }
        }
        public string? Type;

        public CourseType(string Name, int duration)
        {
            this.Name = Name;
            DurationInMonths = duration;
        }
        public abstract void DisplayCourseDetails(); // abstract method
    }
}