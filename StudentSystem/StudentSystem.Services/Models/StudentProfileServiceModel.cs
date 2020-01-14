namespace StudentSystem.Services.Models
{
    public class StudentProfileServiceModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public int StudentId { get; set; }

        public int Courses { get; set; }

        public double? AverageMark { get; set; }
    }
}
