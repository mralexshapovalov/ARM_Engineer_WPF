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
using System.Data;

namespace ARM_Engineer.Employee
{
    /// <summary>
    /// Логика взаимодействия для DivisionWindow.xaml
    /// </summary>
    public partial class DivisionWindow : Window
    {
        public Division selectedItem;
        List<Division> list;
        public DivisionWindow()
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            Data_output();
        }
        void Data_output()
        {
            list = new List<Division>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Division\"", DataBase.Connection());
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
        }
        private void dataGridDivision_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGridDivision.SelectedItems.Count == 1)
            {
                selectedItem = (Division)dataGridDivision.SelectedItems[0];
                DialogResult = true;
                Close();
            }
        }
    }
}
