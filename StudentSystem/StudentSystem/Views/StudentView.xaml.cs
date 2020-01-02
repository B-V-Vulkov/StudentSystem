namespace StudentSystem.Views
{
    using StudentSystem.ViewModels;
    using System.Windows.Controls;

    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
            this.DataContext = new StudentViewModel();
        }
    }
}
