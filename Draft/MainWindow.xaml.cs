using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Data.Common;
using System.Data;

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

<<<<<<< Updated upstream
            WarehouseDataEntities db = new WarehouseDataEntities();

            var storage = from d in db.Items select d;
=======
        public void LoadDataGrid()
        {
            DataTable table = new DataTable("Data table");

            DataColumn name = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Name",
                Unique = true,
                ReadOnly = true
            };
            table.Columns.Add(name);

            DataColumn quantity = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Quantity",
                Unique = true,
                ReadOnly = true
            };
            table.Columns.Add(quantity);

            foreach(var record in DatabaseHandler.DataBase.Items)
            {
                DataRow _row = table.NewRow();
                _row["Name"] = record.Name;
                _row["Quantity"] = record.Quantity;
            }

            //Storage.ItemsSource = new DataView(table);

        }

        public void ReloadList()
        {
>>>>>>> Stashed changes

            var storage = from d in DatabaseHandler.DataBase.Items select d;

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

<<<<<<< Updated upstream
=======
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO Detemine if the program can work on a single window
            Window _window = new ItemInsterion();
            _window.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("RELOADING");
            //LoadDataGrid();
            ReloadList();
>>>>>>> Stashed changes
        }
    }
}
