namespace StudentSystem.Views
{
    using StudentSystem.ViewModels;
    using System.Windows.Controls;

    public partial class TeacherView : UserControl
    {
        public TeacherView()
        {
            InitializeComponent();
            this.DataContext = new TeacherViewModel();
        }
    }
}
