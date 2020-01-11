namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Teachers")]
    public class Teacher
    {
        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key]
        public int TeacherId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
