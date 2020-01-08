using StudentSystem.Services.Models;
using StudentSystem.Services.Services;
using System.Collections.Generic;

namespace StudentSystem.ViewModels.UserProfiles.Student
{
    public class StudentCoursesViewModel
    {
        private UserService service;

        public StudentCoursesViewModel()
        {
            this.service = new UserService();
        }

        public List<StudentCourses> Courses
        {
            get
            {
                return this.service.GetCourses();
            }
        }

    }
}
