﻿namespace StudentSystem.Views
{
    using System.Windows.Controls;

    using ViewModels;

    public partial class TeachersView : UserControl
    {
        public TeachersView()
        {
            InitializeComponent();
            this.DataContext = new TeachersViewModel();
        }
    }
}
