using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.StudentPerformanceAnalyzer
{
    // student class
    public class Student
    {
        public string? Name;
        public int RollNo;
        public Student(string Name, int roll)
        {
            this.Name = Name;
            RollNo = roll;
        }
    }
}