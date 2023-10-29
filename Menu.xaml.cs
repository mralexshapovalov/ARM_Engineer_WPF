using ARM_Engineer.Approval_status;
using ARM_Engineer.Employee;
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

namespace ARM_Engineer
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

        

       

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Approval_status_Windows approval_Status_Windows = new Approval_status_Windows();
            approval_Status_Windows.Show();
        }

        private void button_Employee_Click(object sender, RoutedEventArgs e)
        {
            Employee_Table_Window employee_Table_Window = new Employee_Table_Window();
            employee_Table_Window.Show();
        }
    }
}
