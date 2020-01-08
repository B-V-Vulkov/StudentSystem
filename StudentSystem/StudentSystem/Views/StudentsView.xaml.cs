namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class StudentsView : UserControl
    {
        public StudentsView()
        {
            InitializeComponent();
            this.DataContext = new StudentsViewModel();
        }
    }
}
