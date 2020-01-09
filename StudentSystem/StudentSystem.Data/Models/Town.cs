namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
            this.Users = new HashSet<User>();
        }

        public int TownId { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
