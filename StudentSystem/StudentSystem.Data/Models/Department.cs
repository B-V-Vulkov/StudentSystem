using System.Collections.Generic;

namespace StudentSystem.Data.Models
{
    public class Department
    {
        public Department()
        {
            this.Users = new HashSet<User>();
        }

        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
