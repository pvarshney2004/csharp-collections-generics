using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.StudentPerformanceAnalyzer
{
    /*
Student Performance Analyzer
Problem Statement
Create a C# program to analyze student performance.
Each student appears for multiple subjects.
Store:
● Student details in a List<Student>
● Marks in a Dictionary<int, List<int>> (RollNo → Marks)
Tasks
1. Calculate average marks for each student.
2. A student passes if:
○ Average ≥ 40
○ No subject mark < 30
3. Display:
○ Students who passed overall but failed in at least one subject
○ Top scorer of each subject
4. Remove students who failed 3 consecutive exams.
Edge Cases
● Student with no marks recorded
● Marks exactly 30 or 40
● Subjects count differs per student
● Removing items while iterating a collection
● Duplicate roll numbers
    */
    public class StudentAnalyzer
    {
        private List<Student> students; // students record
        private Dictionary<int, List<int>> marks; // marks record of students (roll->marks)

        public StudentAnalyzer(List<Student> students, Dictionary<int, List<int>> marks)
        {
            this.students = students;
            this.marks = marks;
        }

        // method to calculate and display average marks of each student
        public void CalculateAverageMarks()
        {
            foreach (Student s in students)
            {
                if (!marks.ContainsKey(s.RollNo) || marks[s.RollNo].Count == 0)
                {
                    System.Console.WriteLine($"Marks records for {s.Name} not exist.");
                    continue;
                }
                List<int> ll = marks[s.RollNo];
                double avg = ll.Average();
                bool isFailed = ll.Any(m => m < 30);
                System.Console.WriteLine($"Student Name: {s.Name} | Average: {avg}");
                if (avg >= 40 && !isFailed)
                {
                    System.Console.WriteLine("---Passed\n");
                }
                else
                {
                    System.Console.WriteLine("---Failed\n");
                }

            }
        }

        // displaying students who passed overall but failed in at least one subject
        public void Display()
        {
            System.Console.WriteLine("\nStudents who passed overall but failed in at least one subject: ");
            int c = 0;
            foreach (Student s in students)
            {
                if (!marks.ContainsKey(s.RollNo) || marks[s.RollNo].Count == 0)
                {
                    continue;
                }
                List<int> ll = marks[s.RollNo];
                double avg = ll.Average();
                bool failedInAtLeastOne = ll.Any(m => m < 30);
                if (avg >= 40 && failedInAtLeastOne)
                {
                    System.Console.WriteLine(s.Name);
                    c++;
                }

            }
            if (c == 0) System.Console.WriteLine("---No data.");
        }

        // displaying top scorer from each subject
        public void DisplayTopScorerPerSubject()
        {
            System.Console.WriteLine("\nTop scorer for each subject: ");
            int maxSubjects = marks.Values.Max(m => m.Count);
            for (int i = 0; i < maxSubjects; i++)
            {
                string topStudent = "";
                int topMarks = -1;

                foreach (Student s in students)
                {
                    if (marks.ContainsKey(s.RollNo) && marks[s.RollNo].Count > i)
                    {
                        if (marks[s.RollNo][i] > topMarks)
                        {
                            topMarks = marks[s.RollNo][i];
                            topStudent = s.Name;
                        }
                    }
                }
                System.Console.WriteLine($"Subject: {i + 1} | Top Score: {topMarks} | Top Student Name: {topStudent}");
            }
        }

        // removing students who failed in three subjects
        public void RemoveStudentsFailedInThreeSubjects()
        {
            List<Student> removeList = new List<Student>();

            foreach (Student student in students)
            {
                if (marks.ContainsKey(student.RollNo))
                {
                    int failedCount = marks[student.RollNo].Count(m => m < 30);
                    if (failedCount >= 3)
                    {
                        removeList.Add(student);
                    }
                }
            }

            foreach (Student s in removeList)
            {
                students.Remove(s);
            }
        }

        // displaying remaining students
        public void DisplayRemainingStudents()
        {
            Console.WriteLine("\nRemaining Students After Removal:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

    }
}