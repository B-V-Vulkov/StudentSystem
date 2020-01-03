namespace StudentSystem.Views
{
    using StudentSystem.ViewModels;
    using System;
    using System.Windows.Controls;

    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
        }

        private void Test(object sender, System.Windows.RoutedEventArgs e)
        {
            frame.Source = new Uri("NavigationView.xaml", UriKind.Relative);


        }
    }
}
