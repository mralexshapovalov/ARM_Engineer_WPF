using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Логика взаимодействия для FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        public string FilterName { get { return textboxFilterName.Text; } set { } }
        Employee model;
        string valueString;
        public bool IsBoolen = false;

        Employee_Table_Window employee_Table_Window;
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

      

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            employee_Table_Window=new Employee_Table_Window();



            if (comboboxForSearch.Text == "Имя")
            {
               valueString= textboxFilterName.Text;
                if(textboxFilterName.Text !="")
                {
                    employee_Table_Window.Filter(ref valueString);
                    IsBoolen = true;
                    if(IsBoolen == true)
                    {
                        Close();
                    }
                    
                }
            }
         
        }
        public string ReturnValue()
        {
            return valueString;
        }

        public string filterName { get; set; } 





    }
}
