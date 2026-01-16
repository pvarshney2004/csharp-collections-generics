using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    // generics class
    public class Resume<T> where T : JobRole
    {
        private List<T> applicants = new List<T>(); // list to store diffrent applicant details

        public void Add(T applicant)
        {
            applicants.Add(applicant);
        }

        public void ScreenResumes()
        {
            foreach (var applicant in applicants)
            {
                applicant.Evaluate();
            }
        }
    }
}