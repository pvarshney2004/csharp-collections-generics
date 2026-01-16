using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    public class ResumeProcessor
    {
        // generic method to evaluate resume
        public static void ProcessResume<T>(T candidate)
            where T : JobRole
        {
            Console.WriteLine("AI Screening Started...");
            candidate.Evaluate();
        }
    }
}