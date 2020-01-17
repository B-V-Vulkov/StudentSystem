namespace StudentSystem.Views.UserProfiles.Administrator
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Administrator;

    public partial class AdministratorAddTeacherView : UserControl
    {
        public AdministratorAddTeacherView()
        {
            InitializeComponent();
            this.DataContext = new AdministratorAddTeacherViewModel();
        }
    }
}
