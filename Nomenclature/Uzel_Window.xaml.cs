using ARM_Engineer.Database;
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

namespace ARM_Engineer.Nomenclature
{
    /// <summary>
    /// Interaction logic for Uzel_Window.xaml
    /// </summary>
    public partial class Uzel_Window : Window
    {
        public Uzel selectedItem;
        List<Uzel> list;
        public Uzel_Window()
        {
            InitializeComponent();
            Data_output();
        }


        void Data_output()
        {
            list = new List<Uzel>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Aggregate\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Uzel());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                datagridUzel.ItemsSource = list;
            }
            reader.Close();
        }

        private void datagridUzel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (datagridUzel.SelectedItems.Count == 1)
            {
                selectedItem = (Uzel)datagridUzel.SelectedItems[0];
                DialogResult = true;
                Close();
            }
        }
    }
}
