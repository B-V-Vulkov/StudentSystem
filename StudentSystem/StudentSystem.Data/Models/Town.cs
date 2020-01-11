namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Towns")]
    public class Town
    {
        public Town()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int TownId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
