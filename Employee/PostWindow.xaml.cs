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
    public partial class PostWindow : Window
    {
        public Post selectedItem;
        List<Post> list;
        public PostWindow()
        {
            InitializeComponent();
            Data_output();
        }

        void Data_output()
        {
            list = new List<Post>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Post\"", DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Post());
                    list.Last().ID = reader.GetInt32("id");
                    list.Last().Name = reader.GetString("name");
                }
                dataGrid_Post.ItemsSource = list;
            }
        }
        private void dataGrid_Post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_select_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid_Post.SelectedItems.Count == 1)
            {
                selectedItem = (Post)dataGrid_Post.SelectedItems[0];
                DialogResult = true;
                Close();
            }
        }
    }
}

