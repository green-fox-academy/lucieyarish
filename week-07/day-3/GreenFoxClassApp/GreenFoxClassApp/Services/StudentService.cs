using System.Collections.Generic;
using GreenFoxClassApp.Models;

namespace GreenFoxClassApp
{
    public class StudentService
    {
        public static List<Student> AllStudents;
        public StudentService()
        {
            AllStudents = new List<Student>()
            {
                new Student("Sam"),
                new Student("Bob"),
                new Student("Phil")
            };
        }
        
        public List<Student> FindAll()
        {
            return AllStudents;
        }

        public void Save(Student student)
        {
            AllStudents.Add(student);
        }
    }
}