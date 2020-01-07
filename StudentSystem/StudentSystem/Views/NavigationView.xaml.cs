namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
        }
    }
}
