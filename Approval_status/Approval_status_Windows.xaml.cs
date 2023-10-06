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

namespace ARM_Engineer.Approval_status
{
    /// <summary>
    /// Interaction logic for Approval_status_Windows.xaml
    /// </summary>
    public partial class Approval_status_Windows : Window
    {
        public Approval_status_Windows()
        {
            InitializeComponent();
            var list = new List<Approval_status>();

            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Approval_status\"", DataBaseConnection.Connection());
            //int rows_changed = npgc.ExecuteNonQuery();//Если запрос не возвращает таблицу

            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Approval_status());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);

                    if (reader.IsDBNull(2))
                    {
                        list.Last().Description = null;
                    }
                    else
                    {
                        list.Last().Description = reader.GetString(2);
                    }
                }
            }
            dataGrid_Approval_status.ItemsSource = list;
        }
    }

    class Approval_status
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }







    }
}
