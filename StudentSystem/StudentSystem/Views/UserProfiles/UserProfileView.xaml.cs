namespace StudentSystem.Views.UserProfiles
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles;

    public partial class UserProfileView : UserControl
    {
        public UserProfileView()
        {
            InitializeComponent();
            this.DataContext = new UserProfileViewModel();
        }
    }
}
