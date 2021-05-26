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
    /// Interaction logic for AddPayment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public ObservableCollection<Categories> Categorylist { get; set; } = new ObservableCollection<Categories>();
        public Window parent;
        public Payment()
        {
         
            InitializeComponent();
            DataContext = this;
            Categorylist = DBConntext.getCategories();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Decimal.TryParse(AmountTextbox.Text, out var amount);

            if (!string.IsNullOrEmpty(AmountTextbox.Text) && amount > 0 && DateDatePicker.SelectedDate != null && CategorieComboBox.SelectedItem != null)
            {
                Payments newpayment = new Payments()
                {
                    Description = DescriptionTextbox.Text,
                    Amount = amount,
                    Date = (DateTime)DateDatePicker.SelectedDate,
                    IsIncome = (bool)IsIncomeCheckbox.IsChecked,
                    CategoryId = ((Categories)CategorieComboBox.SelectedItem).Id
                };
                DBConntext.AddPayment(newpayment);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }
    }
}
