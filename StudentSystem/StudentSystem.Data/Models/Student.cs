namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Students")]
    public class Student
    {
        public Student()
        {
            this.CoursesEnrolled = new HashSet<StudentCourse>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<StudentCourse> CoursesEnrolled { get; set; }
    }
}
