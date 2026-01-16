using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    // subclass overriding abstract method of base class
    public class SoftwareEngineer : JobRole
    {
        public override void Evaluate()
        {
            System.Console.WriteLine($"Applicant Name: {ApplicantName}");
            System.Console.WriteLine("Evaluating Software Engineer Resume....");
        }
    }
}