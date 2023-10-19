using ARM_Engineer.Approval_status;
using ARM_Engineer.Database;
using ARM_Engineer.Employee;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace ARM_Engineer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Approval_status_Windows approval_status = new Approval_status_Windows();
            approval_status.Show();
        }

        private void Employee_Buton_Click(object sender, RoutedEventArgs e)
        {
            Employee_Table_Window employee_Table_Window = new Employee_Table_Window();
            employee_Table_Window.Show();
        }
    }
}
