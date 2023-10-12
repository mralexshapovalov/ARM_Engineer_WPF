using ARM_Engineer.Database;
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

namespace ARM_Engineer.Employee
{
    /// <summary>
    /// Interaction logic for Employee_Table_Window.xaml
    /// </summary>
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
                    list.Last().Name = reader.GetString(2);
                    if (reader.IsDBNull(2))
                    {
                        list.Last().Division = null;
                    }
                    else
                    {
                        list.Last().Division = reader.GetString(2);
                    }

                }
                Employee_Table_dataGrid.ItemsSource = list;
            }
        }

        private void Employee_Table_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
