namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Services;
    using Services.Models;
    using Services.Contracts;

    public class TeachersViewModel
    {
        #region Declarations

        private ITeacherService teacherService;

        #endregion

        #region Initializations

        public TeachersViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<TeacherServiceModel> Teachers { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            this.teacherService = new TeacherService();

            this.Teachers = teacherService.GetTeachers();
        }

        #endregion

    }
}
