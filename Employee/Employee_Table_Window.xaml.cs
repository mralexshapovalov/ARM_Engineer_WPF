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
        List<Employee> list;
        public Employee_Table_Window()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<Employee>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Employee\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Employee());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Service_number = reader.GetString(1);
                    list.Last().Name = reader.GetString(2);
                    list.Last().Division = reader.GetString(3);
                    list.Last().DataEmployee = reader.GetDateTime(4);
                    list.Last().DateDismissial = reader.GetDateTime(5);
                    list.Last().Post = reader.GetString(6);
                    list.Last().ID_Orgainzation = reader.GetInt32(7);
                    list.Last().YearOfBirth = reader.GetDateTime(8);
                }
                Employee_Table_dataGrid.ItemsSource = list;
            }
        }

        private void Employee_Table_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Employee_Table_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window();
            employee_Window.Show();
        }

       

    }
}
