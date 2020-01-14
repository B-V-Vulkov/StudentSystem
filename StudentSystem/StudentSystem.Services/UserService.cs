namespace StudentSystem.Services
{
    using System.Linq;

    using Data;
    using Contracts;

    public class UserService : IUserService
    {
        public string GetUserFullName(int userId)
        {
            string name;

            using (var data = new StudentSystemDbContext())
            {
                name = data.Users
                    .Where(x => x.UserId == userId)
                    .Select(x => string.Concat(x.FirstName + " " + x.LastName))
                    .ToString();
            }

            return name;
        }
    }
}
