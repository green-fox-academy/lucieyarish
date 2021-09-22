using System;
namespace GreenFoxInheritance
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} old {Gender}");
        }
    }
}
