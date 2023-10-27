using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Create_an_OOP_Based_System_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataStorage = SchoolDataStorage.Instance;
            var factory = new SchoolFactory();

            // Create and add students
            dataStorage.Students.Add(factory.CreateStudent("shiva", "Class A"));
            dataStorage.Students.Add(factory.CreateStudent("ramesh", "Class B"));

            // Create and add teachers
            dataStorage.Teachers.Add(factory.CreateTeacher("Teacher 1", "Class X"));
            dataStorage.Teachers.Add(factory.CreateTeacher("Teacher 2", "Class Y"));

            // Create and add subjects
            dataStorage.Subjects.Add(factory.CreateSubject("Maths", "MATH101", dataStorage.Teachers[0]));
            dataStorage.Subjects.Add(factory.CreateSubject("Science", "SCI101", dataStorage.Teachers[1]));

            // Display students in a class
            Console.WriteLine("Students in Class A:");
            foreach (var student in dataStorage.Students)
            {
                if (student.ClassAndSection == "Class A")
                {
                    Console.WriteLine(student.Name);
                }
            }

            // Display subjects taught by a teacher
            Console.WriteLine("Subjects taught by Teacher 1:");
            foreach (var subject in dataStorage.Subjects)
            {
                if (subject.Teacher == dataStorage.Teachers[0])
                {
                    Console.WriteLine(subject.Name);
                }
            }
        }
    }
}