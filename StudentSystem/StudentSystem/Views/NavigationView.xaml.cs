namespace StudentSystem.Views
{
    using StudentSystem.ViewModels;
    using System.Windows.Controls;

    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
        }
    }
}
