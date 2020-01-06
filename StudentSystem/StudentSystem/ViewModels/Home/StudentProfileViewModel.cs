using StudentSystem.Services.Models;
using StudentSystem.Services.Services;
using System.Collections.Generic;

namespace StudentSystem.ViewModels.Home
{
    public class StudentProfileViewModel : BaseViewModel
    {
        #region Declarations

        private List<StudentCourses> courses;

        private UserService service;

        #endregion

        #region Initializations

        public StudentProfileViewModel()
        {
            this.service = new UserService();

            this.courses = new List<StudentCourses>();
            this.Courses = service.GetCourses();
        }

        #endregion

        #region Properties

        public List<StudentCourses> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Methods
        #endregion
    }
}
