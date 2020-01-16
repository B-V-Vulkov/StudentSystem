namespace StudentSystem.Views.UserProfiles.Administrator
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Administrator;

    public partial class AdministratorTeachersView : UserControl
    {
        public AdministratorTeachersView()
        {
            InitializeComponent();
            this.DataContext = new AdministratorTeachersViewModel();
        }
    }
}
