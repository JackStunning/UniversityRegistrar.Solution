using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<StudentCourse>();
            this.Departments = new List<Department>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string EnrollmentDate {get; set;}
        public virtual ICollection<StudentCourse> Courses { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

        
    }
}