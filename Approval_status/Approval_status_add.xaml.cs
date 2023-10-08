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
using System.Xml.Linq;

namespace ARM_Engineer.Approval_status
{
    public partial class Approval_status_add : Window
    {
        public Approval_status_add()
        {
            InitializeComponent();
        }

        private void button_Save_Approval_status_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Name_Approval_status.Text != "" & textBox_Name_Approval_status.Text != "")
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into \"Approval_status\" (\"Name\", \"Description\") values(@Name,@Description)", DataBaseConnection.Connection());
                    cmd.Parameters.Add(new NpgsqlParameter("@Name", textBox_Name_Approval_status.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Description", textBox_Name_Approval_status.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                }
                Close();


            } 
        }
    }
}
