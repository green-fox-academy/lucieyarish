using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            student.Question(teacher);
            teacher.Teach(student);
        }
    }
}
