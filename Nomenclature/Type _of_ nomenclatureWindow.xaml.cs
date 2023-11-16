using ARM_Engineer.Database;
using ARM_Engineer.Technic;
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
    /// Interaction logic for Type__of__nomenclature.xaml
    /// </summary>
    public partial class Type_of_nomenclatureWindow : Window
    {
        public TypeOfNomenclature selectedItem;
        List<TypeOfNomenclature> list;
        public Type_of_nomenclatureWindow()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<TypeOfNomenclature>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Aggregate\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new TypeOfNomenclature());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                datagridTypeOfNomenclature.ItemsSource = list;
            }
            reader.Close();
        }

        private void datagridTypeOfNomenclature_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (datagridTypeOfNomenclature.SelectedItems.Count == 1)
            {
                selectedItem = (TypeOfNomenclature)datagridTypeOfNomenclature.SelectedItems[0];
                DialogResult = true;
                Close();
            }
        }
    }
}
