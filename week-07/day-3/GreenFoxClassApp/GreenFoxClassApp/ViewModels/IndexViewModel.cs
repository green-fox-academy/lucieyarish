using System.Collections.Generic;
using GreenFoxClassApp.Models;

namespace GreenFoxClassApp.ViewModels
{
    public class IndexViewModel
    {
        public List<Student> AllStudents { get; }

        public IndexViewModel(List<Student> students)
        {
            AllStudents = students;
        }
    }
}