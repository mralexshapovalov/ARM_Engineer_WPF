using ARM_Engineer.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        string openMode;
        ApprovalStatus model;
       
        public Approval_status_add(string openMode, ApprovalStatus model)
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.openMode = openMode;
            this.model = model;

            if(openMode == "Изменить")
            {
                textBox_Name_Approval_status.Text = model.Name; 
                textBox_Description_Approval_status.Text = model.Description;
            }
        }
        private void button_Save_Approval_status_Click(object sender, RoutedEventArgs e)
        {
           if(openMode == "Добавить")
           {
          
                if (textBox_Name_Approval_status.Text != "" & textBox_Name_Approval_status.Text != "")
                {
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into \"Approval_status\" (\"Name\", \"Description\") values(@name,@description)", DataBase.Connection());
                        cmd.Parameters.Add(new NpgsqlParameter("name", textBox_Name_Approval_status.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@description", textBox_Name_Approval_status.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
           } 
           else if(openMode == "Изменить")
           {
                if (textBox_Name_Approval_status.Text != "" & textBox_Name_Approval_status.Text != "")
                {
                    Title = "Статус согласование(Изменить)";
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("update \"Approval_status\" SET \"Name\" = @name,\"Description\"=@description WHERE \"ID\" = @id", DataBase.Connection());
                        cmd.Parameters.Add(new NpgsqlParameter("@id", model.ID));
                        cmd.Parameters.Add(new NpgsqlParameter("@name", textBox_Name_Approval_status.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@description", textBox_Description_Approval_status.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно изменены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
           }
            DialogResult = true;
            Close();
        }
    }
}
