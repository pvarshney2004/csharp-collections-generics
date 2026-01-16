using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    /*
    5. AI-Driven Resume Screening System
o Concepts: Generic Classes, Generic Methods, Constraints
o Problem Statement: Develop a resume screening system that can
process resumes for different job roles while ensuring type safety.
o Hints:
▪ Create an abstract class JobRole (SoftwareEngineer,
DataScientist).
▪ Implement a generic class Resume<T> where T : JobRole to
process resumes dynamically.
▪ Use List<T> to handle multiple job roles in the screening
pipeline.
    */
    public class ResumeMain
    {
        public static void Execute()
        {
            Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
            seResumes.Add(new SoftwareEngineer { ApplicantName = "Prashant" });
            seResumes.Add(new SoftwareEngineer { ApplicantName = "Yash" });

            Resume<DataScientist> dsResumes = new Resume<DataScientist>();
            dsResumes.Add(new DataScientist { ApplicantName = "Aditya" });

            Console.WriteLine("Screening Software Engineer Resumes:");
            seResumes.ScreenResumes();
            Console.WriteLine("\nScreening Data Scientist Resumes:");
            dsResumes.ScreenResumes();

            Console.WriteLine("\nScreening Single Resume Using Generic Method:");
            ResumeProcessor.ProcessResume(
                new DataScientist { ApplicantName = "Aditya Pandey" }
            );
        }
    }
}