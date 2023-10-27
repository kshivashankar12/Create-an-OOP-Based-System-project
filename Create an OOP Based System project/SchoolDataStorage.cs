using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Create_an_OOP_Based_System_project
{
    public class SchoolDataStorage
    {
        private static SchoolDataStorage instance;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Subject> subjects;

        private SchoolDataStorage()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            subjects = new List<Subject>();
        }

        public static SchoolDataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SchoolDataStorage();
                }
                return instance;
            }
        }

        public List<Student> Students => students;
        public List<Teacher> Teachers => teachers;
        public List<Subject> Subjects => subjects;
    }
}
