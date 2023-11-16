using ARM_Engineer.Database;
using ARM_Engineer.Nomenclature;
using ARM_Engineer.Technic;
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

namespace ARM_Engineer.Uint
{
    /// <summary>
    /// Interaction logic for Uint_Windws.xaml
    /// </summary>
    public partial class Aggregate_Windws : Window
    {
        public BrandEquipment selectedItem;
        List<Aggregate> list;
        public Aggregate_Windws()
        {
            InitializeComponent();
        }


        void Data_output()
        {
            list = new List<Aggregate>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Aggregate\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Aggregate());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                datagridAggregate.ItemsSource = list;
            }
            reader.Close();
        }
    }
}
