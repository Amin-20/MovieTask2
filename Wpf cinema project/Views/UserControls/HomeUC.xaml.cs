﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Wpf_cinema_project.Models;
using Wpf_cinema_project.ViewModels;

namespace Wpf_cinema_project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for HomeUC.xaml
    /// </summary>
    /// 


    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            var movieCellViewModel = new MovieCellViewModel();
            this.DataContext = movieCellViewModel;
        }
    }
}
