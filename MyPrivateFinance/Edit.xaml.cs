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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public ObservableCollection<Categories> Categorylist { get; set; } = new ObservableCollection<Categories>();
        public Window parent;
        public Payments SelectedItem { get; set; }
        public Edit(Payments selectedItem)
        {
            InitializeComponent();
            DataContext = this;
            SelectedItem = selectedItem;
            Categorylist = DBConntext.GetCategories();
            setParams(SelectedItem);
        }

        private void setParams(Payments SelectedItem)
        {
            AmountTextbox.Text = SelectedItem.Amount.ToString();
            DescriptionTextbox.Text = SelectedItem.Description.ToString();
            CategorieComboBox.SelectedItem = Categorylist.FirstOrDefault(c => c.Id == SelectedItem.CategoryId);
            DateDatePicker.SelectedDate = SelectedItem.Date;
            IsIncomeCheckbox.IsChecked = SelectedItem.IsIncome;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Decimal.TryParse(AmountTextbox.Text, out var amount);

            if (!string.IsNullOrEmpty(AmountTextbox.Text) && amount > 0 && DateDatePicker.SelectedDate != null && CategorieComboBox.SelectedItem != null)
            {
                DBConntext.UpdatePayment(SelectedItem.Id,DescriptionTextbox.Text, amount, ((Categories)CategorieComboBox.SelectedItem).Id, (DateTime)DateDatePicker.SelectedDate,(bool)IsIncomeCheckbox.IsChecked);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }
    }
}
