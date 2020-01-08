using Prism.Commands;
using StudentSystem.Services.Models;
using StudentSystem.Services.Services;
using System.Collections.Generic;

namespace StudentSystem.ViewModels.UserProfiles.Student
{
    public class StudentCoursesViewModel : BaseViewModel
    {
        private UserService service;

        private List<StudentCourses> courses;

        private DelegateCommand command;


        public StudentCoursesViewModel()
        {
            this.service = new UserService();
            this.Courses = service.GetCourses();
        }

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

        public DelegateCommand Command
        {
            get
            {
                if (this.command == null)
                {
                    this.command = new DelegateCommand(Save);
                }

                return this.command;
            }
        }

        private void Save()
        {
            service.Save(Courses);
        }
    }
}
