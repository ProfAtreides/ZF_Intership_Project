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

namespace Draft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           Core.WarehouseManagament db = new Core.WarehouseManagament();

            var items = from Name in db.Items select Name;

            foreach(var item in items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Quantity)
            }
        }
    }
}
