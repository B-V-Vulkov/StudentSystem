namespace StudentSystem.Views.Home
{
    using System.Windows.Controls;

    using ViewModels.Home;

    public partial class StudentProfileView : UserControl
    {
        public StudentProfileView()
        {
            InitializeComponent();
            this.DataContext = new StudentProfileViewModel();
        }
    }
}
