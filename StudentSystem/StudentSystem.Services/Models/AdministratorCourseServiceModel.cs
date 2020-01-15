namespace StudentSystem.Services.Models
{
    public class AdministratorCourseServiceModel
    {
        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string ExamDate { get; set; }

        public int? TeacherId { get; set; }
    }
}
