using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_an_OOP_Based_System_project
{
    public class SchoolFactory
    {
        public Student CreateStudent(string name, string classAndSection)
        {
            return new Student { Name = name, ClassAndSection = classAndSection };
        }

        public Teacher CreateTeacher(string name, string classAndSection)
        {
            return new Teacher { Name = name, ClassAndSection = classAndSection };
        }

        public Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }
}

