using ARM_Engineer.Approval_status;
using ARM_Engineer.Database;
using ARM_Engineer.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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
        List<EmployeeCard> list;
        public Employee_Table_Window()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<EmployeeCard>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Employee\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new EmployeeCard());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Service_number = reader.GetString(1);
                    list.Last().Name = reader.GetString(2);
                    list.Last().DataEmployee = reader.GetDateTime(3);
                    list.Last().DateDismissial = reader.GetDateTime(4);
                    //list.Last().ID_Division = reader.GetInt32(7);
                    //list.Last().ID_Post = reader.GetInt32(8);
                    // list.Last().ID_Orgainzation = reader.GetInt32(7);
                    //list.Last().YearOfBirth = reader.GetDateTime(8);
                }
                Employee_Table_dataGrid.ItemsSource = list;
            }
        }

        private void Employee_Table_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Employee_Table_dataGrid.SelectedItems.Count == 1)
            {
                Employee_Window employee_Window = new Employee_Window("Изменить", (EmployeeCard)Employee_Table_dataGrid.SelectedItems[0]);
                employee_Window.Title = "Статус согласование(Изменить)";
                employee_Window.ShowDialog();
                if (employee_Window.DialogResult == true)
                {
                    Data_output();
                }
            }
        }

        private void Employee_Table_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Employee_Window employee_Window = new Employee_Window();
            //employee_Window.Show();
        }

        private void Add_Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window("Добавить", null);
            employee_Window.Title = "Статус согласование(Добавить)";
            employee_Window.ShowDialog();

            if (employee_Window.DialogResult == true)
            {
                Data_output();
            }
        }
    }
}
