using System;
using System.Collections.Generic;
using GreenFoxClassApp2.Models;

namespace GreenFoxClassApp2.Services
{
    public class StudentService
    {
        public List<string> Names;
        public bool StudentExists;

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

        public int Count()
        {
            return Names.Count;
        }

        public void Check(string name)
        {
            StudentExists = Names.Contains(name);
        }
    }
}