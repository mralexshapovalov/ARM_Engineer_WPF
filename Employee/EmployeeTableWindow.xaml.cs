﻿using ARM_Engineer.Approval_status;
using ARM_Engineer.Database;
using ARM_Engineer.Models;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

namespace ARM_Engineer.Employee
{
    public partial class Employee_Table_Window : Window
    {
        List<Employee> list;
        DataTable dataTable;
        NpgsqlDataAdapter dataAdapter;
        public Employee_Table_Window()
        {
            InitializeComponent();
            Data_output();
        }
        void Data_output()
        {
            //string filter ="";
            //List<string> filters = new List<string>();
            //if(textBoxFilterName.Text != "")
            //{
            //    filters.Add("\"name\" = "+"\"" + textBoxFilterName.Text+"\"");
            //}

            //for(int i=0; i < filters.Count; i++)
            //{
            //    if (i == filters.Count - 1)
            //    {
            //        filter = filter + filters[i];
            //    }
            //    else
            //    {
            //        filter = filter + filters[i] + " AND ";
            //    }
            //}

            //if(filter != "")
            //{
            //    filter = "WHERE " + filter;
            //}


            list = new List<Employee>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Employee\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Employee());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Service_number = reader.GetString("service_number");
                    list.Last().Name = reader.GetString("name");
                    list.Last().DataEmployee = reader.GetDateTime("date_employee");
                    list.Last().DateDismissial = reader.GetDateTime("date_dismissal");
                    list.Last().ID_Orgainzation = reader.GetInt32("id_organization");
                    list.Last().YearOfBirth = reader.GetDateTime("year_birth");
                    list.Last().ID_Division = reader.GetInt32("id_division");
                    list.Last().ID_Post = reader.GetInt32("id_post");
                }
                dataGridEmployeeTable.ItemsSource = list;
            }
        }

        private void Employee_Table_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Employee_Window employee_Window = new Employee_Window();
            //employee_Window.Show();
        }
        private void Add_Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window("Добавить", new Employee());
            employee_Window.Title = "Статус согласование(Добавить)";
            employee_Window.ShowDialog();

            if (employee_Window.DialogResult == true)
            {
                Data_output();
            }
        }

        private void Employee_Table_dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            for (int i = dataGridEmployeeTable.Columns.Count - 1; i >= 0; i--)
            {
                if (i > 7)
                {
                    dataGridEmployeeTable.Columns.RemoveAt(dataGridEmployeeTable.Columns.Count - 1);
                }
            }
        }

        private void ApplyFilters_Click(object sender, RoutedEventArgs e)
        {


            string searchString = "SELECT * FROM \"Employee\" WHERE concat(\"name\") LIKE '%" + textBoxFilterName.Text + "%'";




            NpgsqlCommand cmd = new NpgsqlCommand(searchString, DataBase.Connection());
            
                

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridEmployeeTable.ItemsSource = dataTable.DefaultView;
                }
            



        }

        private void dataGridEmployeeTable_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (dataGridEmployeeTable.SelectedItems.Count == 1)
            {
                Employee_Window employee_Window = new Employee_Window("Изменить", (Employee)dataGridEmployeeTable.SelectedItems[0]);
                employee_Window.Title = "Статус согласование(Изменить)";
                employee_Window.ShowDialog();
                if (employee_Window.DialogResult == true)
                {
                    Data_output();
                }
            }
        }

        private void textBoxFilterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = textBoxFilterName.Text;
           

          

                string query = "SELECT * FROM \"Employee\" WHERE name ILIKE @searchTerm";
                using (NpgsqlCommand command = new NpgsqlCommand(query, DataBase.Connection()))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridEmployeeTable.ItemsSource = dataTable.DefaultView;
                    }
                }
            
        }
    }
}
