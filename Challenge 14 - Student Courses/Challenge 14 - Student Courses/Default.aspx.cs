using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_14___Student_Courses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignmentButton1_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>()
                {
                new Course() {CourseId = 1, Name = "Econ 101", Students = new List<Student>() {
                  new Student() {StudentId = 1, Name = "Kelly Welly"},
                  new Student() {StudentId = 2, Name = "Jerry Williams"} } },
                new Course() {CourseId = 2, Name = "Discrete Math", Students = new List<Student>() {
                  new Student() {StudentId = 3, Name = "Yolanda Robbins"},
                  new Student() {StudentId = 4, Name = "Pat Kenyon" } } },
                new Course() {CourseId = 3, Name = "History 301", Students = new List<Student>() {
                  new Student() {StudentId = 5, Name = "Michael Strahan"},
                  new Student() {StudentId = 6, Name = "Robin Wiggins"} } }
                };
            foreach (var course in courses)
            {
                resultLabel.Text += string.Format("<br>Course: {0} - {1}", course.CourseId, course.Name);
                    foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format("<br> &nbsp; &nbsp;Student: {0} - {1}", student.StudentId, student.Name);
                }
            }
        }

        protected void assignmentButton2_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId = 1, Name = "Algebra 3" };
            Course course2 = new Course() { CourseId = 2, Name = "Physiology" };
            Course course3 = new Course() { CourseId = 3, Name = "Business Law" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student {StudentId = 1, Name = "Kelly Welly", Courses = new List<Course> {course1, course2 } } },
                { 2, new Student {StudentId = 2, Name = "Jerry Williams", Courses = new List<Course> { course2, course3 } } },
                { 3, new Student {StudentId = 3, Name = "Yolanda Robbins", Courses = new List<Course> {course3, course1 } } }        
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br>Student:  {0} - {1}, ", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br>&nbsp; &nbsp;Course: {0} - {1}, ", course.CourseId, course.Name);
                }
            };
        }

        protected void assignmentButton3_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = 723747;
            student.Name = "Kelly Welly";
            student.Enrollments = new List<Enrollment>()
            {
                new Enrollment {Grade = 96, Course = new Course {CourseId = 1, Name = "Physiology 101" } },
                new Enrollment {Grade = 92, Course = new Course {CourseId = 2, Name = "Algebra 3" } },
                new Enrollment {Grade = 93, Course = new Course {CourseId = 1, Name = "Differential Equations" } },
            };

            resultLabel.Text += String.Format("<br>&nbsp;Student: {0} - {1}, ", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("<br>&nbsp; &nbsp;Enrollment: {0} - Grade:  {1} ", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}