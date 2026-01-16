using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    // abstract class
    public abstract class JobRole
    {
        public string? ApplicantName;
        public abstract void Evaluate();
    }
}