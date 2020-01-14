namespace StudentSystem.Services.Contracts
{
    using System;
    using System.Collections.Generic;

    using Models;

    public interface ITeacherStudentService
    {
        IList<TeacherStudentServiceModel> GetTeacherStudents(int courseId);

        void SaveStudentMarks(IList<TeacherStudentServiceModel> students, int courseId);
    }
}
