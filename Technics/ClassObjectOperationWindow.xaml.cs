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
    /// Interaction logic for ClassObjectOperationWindow.xaml
    /// </summary>
    public partial class ClassObjectOperationWindow : Window
    {
        public ClassObjectOperation selectedItem;
        List<ClassObjectOperation> list;
        public ClassObjectOperationWindow()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<ClassObjectOperation>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Class_object_operation\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new ClassObjectOperation());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                dataGridClassObjectOperation.ItemsSource = list;
            }
            reader.Close();
        }
    }
}
