using System;
using System.Collections.Generic;
namespace GreenFoxInheritance
{
    public class Cohort
    {
        protected string CohortName;
        protected List<Student> Students;
        protected List<Mentor> Mentors;

        public Cohort(string name)
        {
            Students = new List<Student>();
            Mentors = new List<Mentor>();
            this.CohortName = name;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            //Students.Add(new Student());
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {CohortName} cohort has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
