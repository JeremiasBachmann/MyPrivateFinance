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
using System.Windows.Shapes;

namespace MyPrivateFinance
{
    /// <summary>
    /// Interaction logic for CreatingCategory.xaml
    /// </summary>
    public partial class Category : Window
    {
        public ObservableCollection<Categories> Categorylist { get; set; } = new ObservableCollection<Categories>();
        public Category()
        {
            InitializeComponent();
            updateCategories();
        }

 

    private void AddEvent(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                Categories categories = new Categories()
                {
                    Name = textbox.Text
                };
                textbox.Text = "";
                DBConntext.AddCategory(categories);
                updateCategories();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void updateCategories()
        {
            Categorylist.Clear();
            Categorylist = DBConntext.GetCategories();
            listBox.ItemsSource = Categorylist;
        }

        private void DeleteEvent(object sender, RoutedEventArgs e)
        {
            var tempCategory = (Categories)listBox.SelectedItem;
            try
            {
                DBConntext.DeleteCategory(tempCategory);
                updateCategories();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Select Item is used in a Payment");
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Item to Delete");
            }
        }
    }
}
