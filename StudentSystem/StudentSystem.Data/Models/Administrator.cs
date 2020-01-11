namespace StudentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Administrators")]
    public class Administrator
    {
        [Key]
        public int AdministratorId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
