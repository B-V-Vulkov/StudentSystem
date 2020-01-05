namespace StudentSystem.Views.Home
{
    using System.Windows.Controls;

    using ViewModels.Home;

    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            this.DataContext = new HomeViewModel();
        }
    }
}
