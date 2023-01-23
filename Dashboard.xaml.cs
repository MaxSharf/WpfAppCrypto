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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public List<Currency> currenciesD = new List<Currency>();
        
        public Dashboard()
        {
            InitializeComponent();
            currenciesD = APIData.GetCurrency();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Bitcoin")
                {
                    lblBTC.Content = item.priceUsd;
                }
            } 
            
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Ethereum")
                {
                    lblETH.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Dogecoin")
                {
                    lblDOGE.Content = item.priceUsd;
                }
            } 
            foreach(Currency item in currenciesD)
            {
                if(item.name == "XRP")
                {
                    lblXRP.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Cardano")
                {
                    lblADA.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "TRON")
                {
                    lblTRX.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Litecoin")
                {
                    lblLTC.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Cosmos")
                {
                    lblATOM.Content = item.priceUsd;
                }
            }
            foreach(Currency item in currenciesD)
            {
                if(item.name == "Solana")
                {
                    lblSOL.Content = item.priceUsd;
                }
            }




        }
    }
}
