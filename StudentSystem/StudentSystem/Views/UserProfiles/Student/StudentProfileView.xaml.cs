namespace StudentSystem.Views.UserProfiles.Student
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Student;

    public partial class StudentProfileView : UserControl
    {
        public StudentProfileView()
        {
            InitializeComponent();
            this.DataContext = new StudentProfileViewModel();
        }
    }
}
