using System;
namespace GreenFoxInheritance
{
    public class Sponsor : Person
    {
        protected string Company;
        protected int HiredStudents;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
            HiredStudents = 0;
        }

        public Sponsor()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public int Hire()
        {
            return HiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
    }
}
