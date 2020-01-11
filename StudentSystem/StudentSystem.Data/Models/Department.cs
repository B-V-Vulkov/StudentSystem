namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Departments")]
    public class Department
    {
        public Department()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
