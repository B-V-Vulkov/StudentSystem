namespace StudentSystem.Data.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public Administrator Administrator { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? TownId { get; set; }
        public Town Town { get; set; }
    }
}
