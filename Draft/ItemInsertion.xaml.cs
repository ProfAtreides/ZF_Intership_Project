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

namespace Draft
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ItemInsterion : Window
    {
        public ItemInsterion()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ConfirmData_Click(object sender, RoutedEventArgs e)
        {
            string name = InputFormulaTextBox.Text;

            if(name != null)
            {
               var _temp = new Items(InputFormulaTextBox.Text);

                DatabaseHandler.NewElement(_temp);

                this.Close();
            }
        }
    }
}
