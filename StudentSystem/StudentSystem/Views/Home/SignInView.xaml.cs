namespace StudentSystem.Views.Home
{
    using System.Windows.Controls;

    using ViewModels.Home;

    public partial class SignInView : UserControl
    {

        public SignInView()
        {
            InitializeComponent();
            this.DataContext = new SignInViewModel();
        }
    }
}
