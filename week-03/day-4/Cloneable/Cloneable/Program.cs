using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", 20, "male", "BME");
            Student JohnTheClone = (Student)student.Clone();
        }
    }
}
