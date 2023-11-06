using ARM_Engineer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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
    public partial class FilterWindow : Window
    {
        Employee_Table_Window employee_Table_Window;
        Organization filterOrganization;
        public static string sendtext = "";
        public static string combotext = "";
        public static int orgainzationId;
        public static DateTime datePickerFrom;
        public static DateTime datePickerTo;
        public FilterWindow()
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            ComboboxItemsAdd();
        }
        void ComboboxItemsAdd()
        {
            comboboxForSearch.Items.Add("ID");
            comboboxForSearch.Items.Add("Имя");
            comboboxForSearch.Items.Add("Организация");
            comboboxForSearch.Items.Add("Дата");
        }
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            employee_Table_Window = new Employee_Table_Window();
            if (comboboxForSearch.Text == "Имя")
            {
                combotext = comboboxForSearch.Text;
                sendtext = textboxFilterName.Text;
                employee_Table_Window.Filter();
                
            }
            else if (comboboxForSearch.Text == "Организация")
            {
                combotext = comboboxForSearch.Text;
                sendtext = textboxFilterName.Text;
                orgainzationId = filterOrganization.ID;
                employee_Table_Window.Filter();
              
            }
            else if (comboboxForSearch.Text == "Дата")
            {
                combotext = comboboxForSearch.Text;
                datePickerFrom = dataPickerEditFrom.SelectedDate.Value;
                datePickerTo = dataPickerEditTo.SelectedDate.Value;
                employee_Table_Window.Filter();
         
            }

            Close();
        }
        private void buttonClouse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonSearchOrganization_Click(object sender, RoutedEventArgs e)
        {
            OrganizationWindow organizationWindow = new OrganizationWindow();
            organizationWindow.ShowDialog();

            if (organizationWindow.DialogResult == true)
            {
                filterOrganization = new Organization();
                filterOrganization.ID = organizationWindow.selectedItem.ID;
                textboxFilterName.Text = organizationWindow.selectedItem.Name;
            }
        }

        private void comboboxForSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;
           
            if (comboBox.SelectedItem == "Имя")
            {
                textboxFilterName.IsEnabled = true;
            }
            else if (comboBox.SelectedItem == "Организация")
            {
                textboxFilterName.IsEnabled = false;
                buttonSearchOrganization.Visibility = Visibility.Visible;
            }
            else if (comboBox.SelectedItem == "Дата")
            {
               textboxFilterName.Visibility = Visibility.Collapsed;
               dataPickerEditFrom.Visibility = Visibility.Visible;
               dataPickerEditTo.Visibility = Visibility.Visible;
               labelPeriodFrom.Visibility = Visibility.Visible;
               labelPeriodTo.Visibility = Visibility.Visible;
            }
        }
    }
}
