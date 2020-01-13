namespace StudentSystem.Views.UserProfiles.Teacher
{
    using StudentSystem.ViewModels.UserProfiles.Teacher;
    using System.Windows.Controls;

    public partial class TeacherProfileView : UserControl
    {
        public TeacherProfileView()
        {
            InitializeComponent();
            this.DataContext = new TeacherProfileViewModel();
        }
    }
}
