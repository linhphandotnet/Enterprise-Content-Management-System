﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ecm.Archive.ViewModel;

namespace Ecm.Archive.View
{
    /// <summary>
    /// Interaction logic for ForgotPasswordView.xaml
    /// </summary>
    public partial class ForgotPasswordView : UserControl
    {
        public ForgotPasswordView(ForgotPasswordViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            txtUsername.Focus();
        }
    }
}
