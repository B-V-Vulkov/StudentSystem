namespace StudentSystem.Views
{
    using StudentSystem.ViewModels;
    using System.Windows.Controls;

    public partial class TeacherStudentView : UserControl
    {
        public TeacherStudentView()
        {
            InitializeComponent();
            this.DataContext = new TeacherStudentViewModel();
        }
    }
}
