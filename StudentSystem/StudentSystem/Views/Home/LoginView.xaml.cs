﻿namespace StudentSystem.Views.Home
{
    using System.Windows.Controls;

    using ViewModels.Home;

    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}
