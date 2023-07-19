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

            WarehouseDataEntities db = new WarehouseDataEntities();

            var storage = from d in db.Items select d;

            // TODO later move to a seperate class

           GridLength gridLength = new GridLength(30);
            GridLength gridWidth = new GridLength(250);


            const int FONT_SIZE = 15;

            int i = 1;

           foreach(var _item in storage)
            {
                RowDefinition _rowDef = new RowDefinition();
                _rowDef.Height = gridLength;

                
                ItemList.RowDefinitions.Add(_rowDef);

                TextBlock _name = new TextBlock();
                TextBlock _quanitity = new TextBlock();

                _name.Text = _item.Name;
                _name.FontSize = FONT_SIZE;

                _quanitity.FontSize = FONT_SIZE;
                _quanitity.Text = _item.Quantity.ToString();

                Grid.SetRow(_name, i);
                Grid.SetColumn(_name, 0);
                Grid.SetRow(_quanitity, i);
                Grid.SetColumn(_quanitity, 1);


                ItemList.Children.Add(_name);
                ItemList.Children.Add(_quanitity);

                i++;
            }

        }
    }
}
