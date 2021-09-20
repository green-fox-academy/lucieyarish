using System;
namespace TeacherStudent
{
    public class Teacher
    {
        public void Teach(Student student)
        {
            student.Learn();
        }

        public void GiveAnswer()
        {
            Console.WriteLine("The teacher is answering a question.");
        }
    }
}
