using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_14___Student_Courses
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}