using ARM_Engineer.Database;
using ARM_Engineer.Models;
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

namespace ARM_Engineer.Technic
{
    /// <summary>
    /// Interaction logic for VehicleManagementСategoryWindow.xaml
    /// </summary>
    public partial class VehicleManagementCategoryWindow : Window
    {
        public VehicleManagementCategoryWindow()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<Division>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Vehicle_management_category\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Division());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                dataGridDivision.ItemsSource = list;
            }
            reader.Close();
        }
    }
}
