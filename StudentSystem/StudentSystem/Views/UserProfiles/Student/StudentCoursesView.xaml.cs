namespace StudentSystem.Views.UserProfiles.Student
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Student;

    public partial class StudentCoursesView : UserControl
    {
        public StudentCoursesView()
        {
            InitializeComponent();
            this.DataContext = new StudentCoursesViewModel();
        }
    }
}
