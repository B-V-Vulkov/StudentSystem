namespace StudentSystem.Services
{
    using Data;

    public class BaseService
    {
        protected internal readonly StudentSystemDbContext data;

        public BaseService(StudentSystemDbContext dbContext)
        {
            this.data = dbContext;
        }
    }
}
