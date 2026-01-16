using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.StudentPerformanceAnalyzer
{
    public class StudentAnalyzerMain
    {
        public static void Execute()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Alice", 1));
            students.Add(new Student("Bob", 2));
            students.Add(new Student("Charles", 3));
            students.Add(new Student("Dustin", 4));

            Dictionary<int, List<int>> marks = new Dictionary<int, List<int>>
            {
                {1, new List<int>{50, 30, 70}},
                {2, new List<int>{27, 28, 20}},
                {3, new List<int>{30, 40, 30}},
                {4, new List<int>()}
            };

            StudentAnalyzer analyzer = new StudentAnalyzer(students, marks);

            analyzer.CalculateAverageMarks();
            analyzer.Display();
            analyzer.DisplayTopScorerPerSubject();
            analyzer.RemoveStudentsFailedInThreeSubjects();
            analyzer.DisplayRemainingStudents();
        }
    }
}