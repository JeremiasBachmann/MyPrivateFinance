using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace MyPrivateFinance
{
    /// <summary>
    /// Interaction logic for Export.xaml
    /// </summary>
    public partial class Export : Window
    {
        public ObservableCollection<Payments> Paymentlist { get; set; } = new ObservableCollection<Payments>();
        public String filePath { get; set; }
        public Export()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new SaveFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    filePath = fbd.FileName;
                    PathTextbox.Text = filePath;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                Paymentlist = DBConntext.GetPayments();

                 var csv = new StringBuilder();
                foreach (Payments p in Paymentlist)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5}", p.Id, p.Description, p.Amount, p.CategoryId, p.Date, p.IsIncome);
                    csv.AppendLine(newLine);
                }

                File.WriteAllText(filePath, csv.ToString());
                this.Close();
            }
        }
    }
}
