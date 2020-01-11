namespace StudentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public Administrator Administrator { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? TownId { get; set; }
        public Town Town { get; set; }
    }
}
