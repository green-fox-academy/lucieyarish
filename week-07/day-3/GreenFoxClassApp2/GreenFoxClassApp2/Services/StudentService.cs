using System.Collections.Generic;
using GreenFoxClassApp2.Models;

namespace GreenFoxClassApp2.Services
{
    public class StudentService
    {
        public List<string> Names;
        
        public StudentService()
        {
            Names = new List<string> {"Sanyi", "Lilla", "John"};
        }

        public List<string> FindAll()
        {
            return Names;
        }

        public void Save(string student)
        {
            Names.Add(student);
        }
    }
}