﻿using ARM_Engineer.Database;
using Npgsql;
using System;
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
using ARM_Engineer.Models;
using System.Data;

namespace ARM_Engineer.Employee
{
    public partial class OrganizationWindow : Window
    {
        public Organization selectedItem;
        List<Organization> list;
        public OrganizationWindow()
        {
            InitializeComponent();
            Data_output();
        }


        void Data_output()
        {
            list = new List<Organization>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Organization\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Organization());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                dataGrid_Organization.ItemsSource = list;
            }
        }

        private void button_select_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid_Organization.SelectedItems.Count == 1)
            {
                selectedItem = (Organization)dataGrid_Organization.SelectedItems[0];
                DialogResult = true;
                Close();

            }
        }

        private void dataGrid_Organization_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}