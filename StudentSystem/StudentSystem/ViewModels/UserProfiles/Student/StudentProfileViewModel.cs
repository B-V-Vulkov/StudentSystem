namespace StudentSystem.ViewModels.UserProfiles.Student
{
    using Common;
    using Services;

    public class StudentProfileViewModel
    {
        #region Declarations

        private StudentService studentService;

        #endregion

        #region Initializations

        public StudentProfileViewModel()
        {
            this.studentService = new StudentService();
            Initialize();
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public int StudentId { get; set; }

        public int Courses { get; set; }

        public double? AverageMark { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            var student = studentService.GetStudentProfileInfo(User.UserId);

            this.FirstName = student.FirstName;
            this.MiddleName = student.MiddleName;
            this.LastName = student.LastName;
            this.Department = student.Department;
            this.StudentId = student.StudentId;
            this.Courses = student.Courses;
            this.AverageMark = student.AverageMark;
        }

        #endregion
    }
}
