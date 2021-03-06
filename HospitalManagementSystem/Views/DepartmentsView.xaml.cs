﻿using System;
using System.Collections.Generic;
using HospitalManagementSystem.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for DepartmentsView.xaml
    /// </summary>
    public partial class DepartmentsView : UserControl
    {
        public DepartmentsViewModel ViewModel { get; set; }

        public DepartmentsView()
        {
            InitializeComponent();
        }

        private void ClearAddDepartment(object sender, DialogClosingEventArgs eventArgs)
        {
            DepartmentNameTextBox.Clear();
            validation.Text = "";
        }

    }
}
