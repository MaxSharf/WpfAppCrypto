using System;
using System.Collections;
using System.Collections.Generic;
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

namespace WpfAppCrypto
{
    /// <summary>
    /// Interaction logic for Wallet.xaml
    /// </summary>
    /// 

    

    public partial class Wallet : Page
    {
        CurrencyCollection Currency = new CurrencyCollection();

        public Wallet()
        {

           
            
            InitializeComponent();
            DataContext = Currency;

           

        }

        

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {

           
            cbWallet.DisplayMemberPath = "name";
            cbWallet.SelectedValuePath = "name";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

           
            Currency.wallet.Add((Currency)cbWallet.SelectedItem);
            lstWallet.Items.Refresh();

        }

 
    }
}