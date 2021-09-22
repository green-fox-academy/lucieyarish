using System;
namespace GreenFoxInheritance
{
    public class Mentor : Person
    {
        public string Level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Level = level;
        }

        public Mentor()
        {
            Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }
    }
}
