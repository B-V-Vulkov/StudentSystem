namespace StudentSystem.Services.Models
{
    public class TeacherCourseServiceModel
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string ExamDate { get; set; }

        public int StudentsEnrolled { get; set; }
    }
}
