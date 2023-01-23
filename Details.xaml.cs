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

namespace WpfAppCrypto
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Page
    {
        public  List<Currency> currencies2 = new List<Currency>();
        public Details()
        {
            InitializeComponent();
        }

        private void dgCurrency_Loaded(object sender, RoutedEventArgs e)
        {
            currencies2 = APIData.GetCurrency();
            
            dgCurrency.ItemsSource = currencies2;
        }

        private void dgCurrency_MouseUp(object sender, MouseButtonEventArgs e)
        {

            Currency? path = dgCurrency.SelectedItem as Currency;
            MessageBox.Show(" Rank:  " + path.rank + "\n Symbol:  " + path.symbol + "\n Name:  " + path.name + "\n Supply:  " + path.supply + "\n Max supply:  " + path.maxSupply + path.maxSupply + "\n MarketCapUsd:  " + path.marketCapUsd + "\n volumeUsd24Hr:  " + path.volumeUsd24Hr + "\n priceUsd:  " + path.priceUsd + "\n changePercent24Hr:  " + path.changePercent24Hr + "\n vwap24Hr:  " + path.vwap24Hr);


                          
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
