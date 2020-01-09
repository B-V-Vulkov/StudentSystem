namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    public class Course
    {
        public Course()
        {
            this.StudentsEnrolled = new HashSet<StudentCourse>();
        }

        public int CourseId { get; set; }

        public string Name { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<StudentCourse> StudentsEnrolled { get; set; }
    }
}
