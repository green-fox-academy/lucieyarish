using System;
namespace Cloneable
{
    public class Student : Person, ICloneable
    {
        protected string PreviousOrganization;
        protected int SkippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return (Student)this.MemberwiseClone();
        }
    }
}
