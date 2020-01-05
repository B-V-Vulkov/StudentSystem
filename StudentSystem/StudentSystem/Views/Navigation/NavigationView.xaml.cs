namespace StudentSystem.Views.Navigation
{
    using System.Windows.Controls;

    using ViewModels.Navigation;

    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
        }
    }
}
