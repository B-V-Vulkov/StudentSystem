namespace StudentSystem.Views.UserProfiles.Administrator
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Administrator;

    public partial class AdministratorTeacherCourseEnrollmentView : UserControl
    {
        public AdministratorTeacherCourseEnrollmentView()
        {
            InitializeComponent();
            this.DataContext = new AdministratorTeacherCourseEnrollmentViewModel();
        }
    }
}
