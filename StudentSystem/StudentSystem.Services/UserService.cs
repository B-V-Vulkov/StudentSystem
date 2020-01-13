namespace StudentSystem.Services
{
    using System.Linq;

    using Data;

    public class UserService
    {
        public string GetUserFullName(int userId)
        {
            string userFullName = string.Empty;

            using (var context = new StudentSystemDbContext())
            {
                var exportFullName = context.Users
                    .Select(x => new
                    {
                        UserIdd = x.UserId,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                    })
                    .FirstOrDefault(x => x.UserIdd == userId);

                userFullName = exportFullName.FirstName + " " + exportFullName.LastName;
            }

            return userFullName;
        }
    }
}
