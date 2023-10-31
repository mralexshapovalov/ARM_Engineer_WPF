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
    /// Логика взаимодействия для FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        Employee model;
        public FilterWindow()
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            InitializeComponent();
            comboboxForSearch.Items.Add("ID");
            comboboxForSearch.Items.Add("Имя");
            comboboxForSearch.Items.Add("Организация");
        }

        private void buttonClouse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void comboboxForSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            Employee_Table_Window employee_Table_Window = new Employee_Table_Window();
    

            if (comboboxForSearch.Text == "Имя")
            {
                
                if(textboxFilterName.Text !="")
                {
                    FilterName = textboxFilterName.Text;
                    employee_Table_Window.Data_output();
                   
                }
                   
                

            }
           

        }

        public string FilterName { get; set; }
        

        private void textboxFilterName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
