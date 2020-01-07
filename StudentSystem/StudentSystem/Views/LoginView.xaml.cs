namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}
