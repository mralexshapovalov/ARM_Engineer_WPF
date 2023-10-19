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

            if (openMode == "Изменить")
            {
                Output_last_name_first_name_patronymic_Label.Content = model.Name;
                Table_number_TextBox.Text = model.Service_number;
                Name_TextBox.Text = model.Name;
                Date_employment_DatePicker.SelectedDate = model.DataEmployee;
                Date_deletion_DatePicker.SelectedDate = model.DateDismissial;
                DateYearBirth_employment_DatePicker.SelectedDate = model.YearOfBirth;
                textBoxOrganization.Text = model.Organization.Name;
                textBoxPost.Text = model.Post.Name;
                textBoxDivision.Text = model.Division.Name;
            }
        }
        void ChangeAndEmployee()
        {
            if (openMode == "Добавить")
            {
                try
                {
                    if(Date_employment_DatePicker.SelectedDate < Date_deletion_DatePicker.SelectedDate)
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into \"Employee\" (\"service_number\", \"name\",\"date_employee\",\"date_dismissal\",\"id_organization\",\"year_birth\",\"id_division\",\"id_post\" ) " +
                                                         "values(@service_number,@name,@date_employee,@date_dismissal,@id_organization,@year_birth,@id_division,@id_post)",
                                                         DataBase.Connection());
                        cmd.Parameters.Add(new NpgsqlParameter("@service_number", Table_number_TextBox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@name", Name_TextBox.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("@date_employee", Date_employment_DatePicker.SelectedDate));
                        cmd.Parameters.Add(new NpgsqlParameter("@date_dismissal", Date_deletion_DatePicker.SelectedDate));
                        cmd.Parameters.Add(new NpgsqlParameter("@id_organization", model.ID_Orgainzation));
                        cmd.Parameters.Add(new NpgsqlParameter("@year_birth", DateYearBirth_employment_DatePicker.SelectedDate));
                        cmd.Parameters.Add(new NpgsqlParameter("@id_division", model.ID_Division));
                        cmd.Parameters.Add(new NpgsqlParameter("@id_post", model.ID_Post));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Дата увольнение не может быть раньше даты приема на работу!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                   
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
                    NpgsqlCommand cmd = new NpgsqlCommand("update \"Employee\" SET \"service_number\" = @service_number,\"name\"=@name," +
                        "\"date_employee\"=@date_employee,\"date_dismissal\"=@date_dismissal,\"id_organization\"=@id_organization,\"year_birth\" = @year_birth," +
                        "\"id_division\"=@id_division,\"id_post\"=@id_post  WHERE \"id\" = @id",
                        DataBase.Connection());
                    cmd.Parameters.Add(new NpgsqlParameter("@id", model.ID));
                    cmd.Parameters.Add(new NpgsqlParameter("@service_number", Table_number_TextBox.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@name", Name_TextBox.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@date_employee", Date_employment_DatePicker.SelectedDate));
                    cmd.Parameters.Add(new NpgsqlParameter("@date_dismissal", Date_deletion_DatePicker.SelectedDate));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_organization", model.ID_Orgainzation));
                    cmd.Parameters.Add(new NpgsqlParameter("@year_birth", model.YearOfBirth));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_division", model.ID_Division));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_post", model.ID_Post));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно изменены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            //DialogResult = false;
        }

        private void Record_close_Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeAndEmployee();
            
        }

        private void Organization_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Record_Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeAndEmployee();
        }

        private void buttonOrganizationSelect_Click(object sender, RoutedEventArgs e)
        {
            OrganizationWindow organizationWindow = new OrganizationWindow();
            organizationWindow.ShowDialog();

            if (organizationWindow.DialogResult == true)
            {
                model.ID_Orgainzation = organizationWindow.selectedItem.ID;
                textBoxOrganization.Text = model.Organization.Name;
            }
        }

        private void buttonDivisionSelect_Click(object sender, RoutedEventArgs e)
        {
            DivisionWindow divisionWindow = new DivisionWindow();
            divisionWindow.ShowDialog();

            if (divisionWindow.DialogResult == true)
            {
                model.ID_Division = divisionWindow.selectedItem.ID;
                textBoxDivision.Text = model.Division.Name;
            }
        }

        private void buttonPostSelect_Click(object sender, RoutedEventArgs e)
        {
            PostWindow postWindow = new PostWindow();
            postWindow.ShowDialog();

            if (postWindow.DialogResult == true)
            {
                model.ID_Post = postWindow.selectedItem.ID;
                textBoxPost.Text = model.Post.Name;
            }
        }
    }
}
