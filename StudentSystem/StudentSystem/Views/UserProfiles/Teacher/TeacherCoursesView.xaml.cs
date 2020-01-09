namespace StudentSystem.Views.UserProfiles.Teacher
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Teacher;

    public partial class TeacherCoursesView : UserControl
    {
        public TeacherCoursesView()
        {
            InitializeComponent();
            this.DataContext = new TeacherCoursesViewModel();
        }
    }
}
