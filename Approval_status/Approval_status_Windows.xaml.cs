﻿using ARM_Engineer.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ARM_Engineer.Approval_status
{
    public partial class Approval_status_Windows : Window
    {
        public Approval_status_Windows()
        {
            InitializeComponent();
            var list = new List<Approval_status>();

            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Approval_status\"", DataBaseConnection.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Approval_status());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                    if (reader.IsDBNull(2))
                    {
                        list.Last().Description = null;
                    }
                    else
                    {
                        list.Last().Description = reader.GetString(2);
                    }

                    dataGrid_Approval_status.ItemsSource = list;
                }
            }
        }

        private void dataGrid_Approval_status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void dataGrid_Approval_status_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dataGrid_Approval_status.Columns[0].Visibility = Visibility.Collapsed;
            dataGrid_Approval_status.Columns[1].Header = "Статус";
            dataGrid_Approval_status.Columns[2].Header = "Описание";
        }

        private void button_Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            Approval_status_add approval_Status_Add = new Approval_status_add();
            approval_Status_Add.Show();
        }
    }
}
