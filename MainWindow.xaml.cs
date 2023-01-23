using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
 

namespace WpfAppCrypto
{
   
    public partial class MainWindow : Window
    {
         

        
        public MainWindow()
        {    
            InitializeComponent();  
            MainFrame.Content = new Dashboard();
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            changeContent("Dashboard");
            
        }

        private void btnWallet_Click(object sender, RoutedEventArgs e)
        {
            changeContent("Wallet");
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            changeContent("Details");
        }

        public void changeContent(string content)
        {
            switch(content)
            {
                case "Dashboard":
                    MainFrame.Content = new Dashboard();
                    break;
                case "Details":
                    MainFrame.Content = new Details();
                    break;
                case "Wallet":
                    MainFrame.Content = new Wallet();
                    break;
            }

        }

        

        
    }
}
