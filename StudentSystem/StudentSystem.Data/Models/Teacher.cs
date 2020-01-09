namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    public class Teacher
    {
        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }

        public int TeacherId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
