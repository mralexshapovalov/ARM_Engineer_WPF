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

namespace ARM_Engineer.Technic
{
    /// <summary>
    /// Interaction logic for BrandEquipmentWindow.xaml
    /// </summary>
    public partial class BrandEquipmentWindow : Window
    {
        public BrandEquipment selectedItem;
        List<BrandEquipment> list;
        public BrandEquipmentWindow()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<BrandEquipment>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Brand_equipment\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new BrandEquipment());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                dataGridBrandEquipment.ItemsSource = list;
            }
            reader.Close();
        }

        private void dataGridBrandEquipment_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGridBrandEquipment.SelectedItems.Count == 1)
            {
                selectedItem = (BrandEquipment)dataGridBrandEquipment.SelectedItems[0];
                DialogResult = true;
                Close();
            }
        }
    }
}
