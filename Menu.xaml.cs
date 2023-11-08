using ARM_Engineer.Approval_status;
using ARM_Engineer.Employee;
using ARM_Engineer.Part;
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
using ARM_Engineer.Technic;

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
        private void buttonObjectExploitation_Click(object sender, RoutedEventArgs e)
        {
            ObjectExploitation objectExploitation = new ObjectExploitation();
            objectExploitation.Show();
        }
    }
}
