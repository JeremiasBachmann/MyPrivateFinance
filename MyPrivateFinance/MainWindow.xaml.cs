using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace MyPrivateFinance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Payments> Paymentlist { get; set; } = new ObservableCollection<Payments>();
        public event PropertyChangedEventHandler PropertyChanged;
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; OnPropertyChanged("Balance"); } 
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            RefreshPaymentlist();
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addpayment = new Payment();
            addpayment.ShowDialog();
            RefreshPaymentlist();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if ((Payments)PaymentGrid.SelectedItem != null)
            {
                var edit = new Edit((Payments)PaymentGrid.SelectedItem);
                edit.ShowDialog();
                RefreshPaymentlist();
            }
            else
            {
                MessageBox.Show("Select a Item to Edit");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var tempPayment = (Payments)PaymentGrid.SelectedItem;
            using (var _DBContext = new DBConnector())
            {
                try{
                    _DBContext.Payments.Remove(_DBContext.Payments.FirstOrDefault(p => tempPayment.Id == p.Id));
                    _DBContext.SaveChanges();
                    RefreshPaymentlist();
                }
                catch
                {
                    MessageBox.Show("Select a Item to Delete");
                }
            }
        }

        public void RefreshPaymentlist()
        {
            Paymentlist.Clear();
            using (var _DBContext = new DBConnector())
            {
                _DBContext.Payments.ToList().ForEach(p => Paymentlist.Add(p));
                _DBContext.Categories.ToList(); // Zum Lazy Loading verhindern
            }

            Balance = 0;
            Paymentlist.Where(pm => pm.IsIncome == true).ToList().ForEach(p => Balance += p.Amount);
            Paymentlist.Where(pm => pm.IsIncome == false).ToList().ForEach(p => Balance -= p.Amount);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void HelpMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is an application to manage your income");
        }

        private void ManageCategories_Click(object sender, RoutedEventArgs e)
        {
            var category = new Category();
            category.ShowDialog();
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            var export = new Export();
            export.ShowDialog();
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            var statistics = new Stastistics();
            statistics.ShowDialog();
        }
    }
}
