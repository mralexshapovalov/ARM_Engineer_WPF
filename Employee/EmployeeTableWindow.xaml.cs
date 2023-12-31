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
    enum valueForFilter
    {
        
    }
    public partial class Employee_Table_Window : Window
    {
        List<Employee> list;
        FilterWindow filterWindow;
        public bool IsFilterEnable = false;
        public Employee_Table_Window()
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();        
            Data_output();
        }

       public string BuildSQLStringFilter()
       {
            IsFilterEnable = true;
            string names = FilterWindow.sendtext;
            string combotext = FilterWindow.combotext;
            DateTime datePickerFrom = FilterWindow.datePickerFrom;
            DateTime datePickerTo = FilterWindow.datePickerTo;
            string filter = "";
            List<string> filters = new List<string>();

            if (combotext=="Имя")
            {
                filters.Add("\"name\" LIKE " + "'%" + names + "%'");
                lableFilter.Visibility = Visibility.Visible;
                lableFilter.Content = combotext + " : " + names;
            }

            else if (combotext == "Организация")
            {
                filters.Add(" \"id_organization\" = " + "" + FilterWindow.orgainzationId + "");
            }

            else if (combotext == "Дата")
            {
                filters.Add("\"date_employee\" >= " + "'" + datePickerFrom + "'" + " AND " + "\"date_employee\" <= " + "" + "'" + datePickerTo + "'");
            }

            for (int i = 0; i < filters.Count; i++)
            {
                if (i == filters.Count - 1)
                {
                    filter = filter + filters[i];
                }
                else
                {
                    filter = filter + filters[i] + " AND ";
                }
            }

            if (filter != "")
            {
                filter = "WHERE" + filter;
            }

            return filter;
       }
        public void Data_output()
        {
            string filterSQLString;

            if (buttonCancelFilter.IsVisible)
            {
                filterSQLString = "";
            }
            else
            {
                filterSQLString = BuildSQLStringFilter();
            }



            list = new List<Employee>();
            
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Employee\" "+ filterSQLString, DataBase.newConnection); 
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
            else
            {
                dataGridEmployeeTable.ItemsSource = null;
                MessageBox.Show("Запрашиваемые данные ней найдены.Повторите запрос снова","Внимание");
            }

            if(filterSQLString != "")
            {
                buttonCancelFilter.Visibility = Visibility.Visible;
            }

            reader.Close();
        }
        private void Add_Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window("Добавить", new Employee());
            employee_Window.Title = "Статус согласование(Добавить)";
            employee_Window.ShowDialog();
           
            if (employee_Window.DialogResult == true)
            {
                Data_output();
                buttonCancelFilter.Visibility = Visibility.Collapsed;
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
        private void Edit_ContextMenu(object sender, RoutedEventArgs e)
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
        private void Remove_ContextMenu(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную строку?", "Уведомление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Employee request = dataGridEmployeeTable.SelectedItem as Employee;
                string commandText = $"DELETE FROM \"Employee\" WHERE \"id\"=(@id)";
                using (var cmd = new NpgsqlCommand(commandText, DataBase.newConnection))
                {
                    cmd.Parameters.AddWithValue("@id", request.ID);
                    cmd.ExecuteNonQuery();
                }
                Data_output();
            }
        }
        private void dataGridEmployeeTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                if ((e.KeyboardDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    filterWindow = new FilterWindow();
                    filterWindow.ShowDialog();
                    Data_output();
                }
            }
        }
        private void dataGridEmployeeTable_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid x = (DataGrid)this.FindName("dataGridEmployeeTable");
            var index = x.SelectedIndex;
            MessageBox.Show(index.ToString());
        }

        private void buttonCancelFilter_Click(object sender, RoutedEventArgs e)
        {
            IsFilterEnable = false;
            Data_output();
            buttonCancelFilter.Visibility=Visibility.Collapsed;
            lableFilter.Visibility = Visibility.Collapsed;
        }
    }
}
