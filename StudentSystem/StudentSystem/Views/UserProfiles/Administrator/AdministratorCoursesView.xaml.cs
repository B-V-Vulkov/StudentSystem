namespace StudentSystem.Views.UserProfiles.Administrator
{
    using System.Windows.Controls;

    using ViewModels.UserProfiles.Administrator;

    public partial class AdministratorCoursesView : UserControl
    {
        public AdministratorCoursesView()
        {
            InitializeComponent();
            this.DataContext = new AdministratorCoursesViewModel();
        }
    }
}
