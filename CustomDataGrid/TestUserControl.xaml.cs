using MaterialDesignThemes.Wpf;
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

namespace CustomDataGrid
{
    /// <summary>
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        ObservableCollection<Item> list = new ObservableCollection<Item>();
        public TestUserControl()
        {
            InitializeComponent();
            InitializeComponent();
            var helper = new DataHelper();
            list = helper.GetItems();
            this.itemsDataGrid.ItemsSource = list;
        }

        private void Chip_DeleteClick(object sender, RoutedEventArgs e)
        {
            var chip = sender as Chip;

            Item item = itemsDataGrid.SelectedItem as Item;

            if (item != null)
            {
                item.Statuses.RemoveAll(i => i == chip.Content.ToString());
                itemsDataGrid.Items.Refresh();
                //GetVisualChild<DataGridCellsPresenter>
            }
        }
    }
}
