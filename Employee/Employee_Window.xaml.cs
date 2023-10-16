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

namespace ARM_Engineer.Employee
{
    /// <summary>
    /// Interaction logic for Employee_Window.xaml
    /// </summary>
    public partial class Employee_Window : Window
    {
        string openMode;
        Employee model;
        public Employee_Window(string openMode, Employee model)
        {
            InitializeComponent();

            this.openMode = openMode;
            this.model = model;

            if(openMode == "Изменить")
            {
                Output_last_name_first_name_patronymic_Label.Content =model.Name;
                Table_number_TextBox.Text = model.Service_number;
                Name_TextBox.Text = model.Name;
                Division_Combobox.Text = model.Division;
                Date_employment_DatePicker.Text = model.DataEmployee.ToString();
                Date_deletion_DatePicker.Text = model.DateDismissial.ToString();
                Post_Combobox.Text = model.Post;
                Organization_Combobox.Text = model.Organization.ToString();

                
            }
        }

        private void Record_close_Button_Click(object sender, RoutedEventArgs e)
        {
            if (openMode == "Добавить")
            {
                 try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into \"Employee\" (\"Service_number\", \"Name\",\"Division\",\"Date_Employee\",\"Date_dismissal\"," +
                                                              "\"Post\",\"ID_Organization\") " +
                                                              "values(@Service_number,@Name,@Division,@Date_Employee,@Date_dismissal,@Post,@ID_Organization)", 
                                                              DataBase.Connection());
                        cmd.Parameters.Add(new NpgsqlParameter("@Service_number", Table_number_TextBox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Name", Name_TextBox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Division", Division_Combobox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Date_Employee", Date_employment_DatePicker.ToString()));
                        cmd.Parameters.Add(new NpgsqlParameter("@Date_dismissal", Date_deletion_DatePicker.ToString()));
                        cmd.Parameters.Add(new NpgsqlParameter("@Post", Post_Combobox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@ID_Organization", Organization_Combobox.Text));
                        //cmd.Parameters.Add(new NpgsqlParameter("@Year_birth", Output_last_name_first_name_patronymic_Label));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                  }
               
            }
            else if (openMode == "Изменить")
            {
                    Title = "Статус согласование(Изменить)";
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("update \"Employee\" SET \"Service_number\" = @Service_number,\"Name\"=@Name, \"Division\"=@Division," +
                            "\"Date_Employee\"=@Date_Employee,\"Date_dismissal\"=@Date_dismissal," +
                            "\"Post\"=@Post,\"ID_Organization\"=@ID_Organization," +
                            "\"Year_birth\"=@Year_birth) \" WHERE \"ID\" = @ID", 
                            DataBase.Connection());

                        cmd.Parameters.Add(new NpgsqlParameter("@Service_number", Table_number_TextBox));
                        cmd.Parameters.Add(new NpgsqlParameter("@Name", Name_TextBox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Division", Division_Combobox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Date_Employee", Date_employment_DatePicker.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Date_dismissal", Date_deletion_DatePicker.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Post", Post_Combobox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@ID_Organization", Organization_Combobox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@Year_birth", Output_last_name_first_name_patronymic_Label));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно изменены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                    }
            }
            DialogResult = true;
            Close();
        }
    }
}
