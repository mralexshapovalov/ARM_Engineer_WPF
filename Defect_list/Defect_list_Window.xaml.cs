﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ARM_Engineer.Defect_list
{
    /// <summary>
    /// Interaction logic for DefectListWindow.xaml
    /// </summary>
    public partial class DefectListWindow : Window
    {
        public DefectListWindow()
        {
            InitializeComponent();
        }

        private void buttonСreateDefectList_Click(object sender, RoutedEventArgs e)
        {
            AddDefectList addDefectList = new AddDefectList();
            addDefectList.Show();
        }
    }
}
