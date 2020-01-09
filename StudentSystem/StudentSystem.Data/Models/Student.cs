namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    public class Student
    {
        public Student()
        {
            this.CoursesEnrolled = new HashSet<StudentCourse>();
        }

        public int StudentId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<StudentCourse> CoursesEnrolled { get; set; }
    }
}
