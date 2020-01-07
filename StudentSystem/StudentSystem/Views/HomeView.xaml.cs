namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            this.DataContext = new HomeViewModel();
        }
    }
}
