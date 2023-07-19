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

           GridLength gridLength = new GridLength(25);
            GridLength gridWidth = new GridLength(500);

           ColumnDefinition _nameCol = new ColumnDefinition();
           ColumnDefinition _quantityCol = new ColumnDefinition();
            _nameCol.Width = gridWidth;
            _quantityCol.Width = new GridLength(15);


            ItemList.ColumnDefinitions.Add(_nameCol);
            ItemList.ColumnDefinitions.Add(_quantityCol);

           for (int i = 0;i<10;i++)
            {
                var _item = storage.FirstOrDefault(Items => Items.Id == i - 1);

               // if (_item == null) break;
                
                RowDefinition _rowDef = new RowDefinition();
                _rowDef.Height = gridLength;

                
                ItemList.RowDefinitions.Add(_rowDef);

                TextBlock _name = new TextBlock();
                TextBlock _quanitity = new TextBlock();
                _quanitity.FontSize = 20;
                _quanitity.Text = i.ToString();
                _name.Text = "IDK" + i;
                _name.FontSize = 20;
               
                Grid.SetRow(_name, i);
                Grid.SetColumn(_name, 0);
                Grid.SetRow(_quanitity, i);
                Grid.SetColumn(_quanitity, 1);


                ItemList.Children.Add(_name);
                ItemList.Children.Add(_quanitity);
            }

        }
    }
}
