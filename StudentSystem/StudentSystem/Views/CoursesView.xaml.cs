namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class CoursesView : UserControl
    {
        public CoursesView()
        {
            InitializeComponent();
            this.DataContext = new CoursesViewModel();
        }
    }
}
