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

namespace Currency_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Text { get { return int.Parse(amount.Text); } set { } }

        public string ConverterText { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            comboBoxCurrency.Items.Add("EUR"); 
            comboBoxCurrency.Items.Add("USD"); 
            comboBoxCurrency.Items.Add("GBP");

            this.DataContext = this;
        }

        public  void CurrencyConvert()
        {
            var originalAmount = (decimal)Text;
            var convertedAmount = originalAmount;
            if (this.comboBoxCurrency.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 1.95583m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "USD")
            {
                convertedAmount = originalAmount / 1.80810m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "GBP")
            {
                convertedAmount = originalAmount / 2.54990m;
            }
            this.result.Content= originalAmount + " BGN = " +
              Math.Round(convertedAmount, 2) + " " + this.comboBoxCurrency.SelectedItem;
        }

        private void ComboBoxCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrencyConvert();
        }
        
        private void FormConverter_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }
    }
}
