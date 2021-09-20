using System;
namespace TeacherStudent
{
    public class Student
    {
        public void Learn()
        {
            Console.WriteLine("The student is actually learning");
        }

        public void Question(Teacher teacher)
        {
            teacher.GiveAnswer();
        }
    }
}
