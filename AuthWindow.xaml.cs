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
using System.Windows.Shapes;


namespace WpfAppCrypto
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }


        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBox_Login.Text.Trim();
            string password1 = TextBox_Password1.Password.Trim();

            if (login.Length < 5)
            {
                TextBox_Login.ToolTip = "Invalid login!";
                TextBox_Login.Background = Brushes.DarkRed;
            }

            else if (password1.Length < 5)
            {
                TextBox_Password1.ToolTip = "Invalid password!";
                TextBox_Password1.Background = Brushes.DarkRed;
            }
            else
            {
                TextBox_Login.ToolTip = "";
                TextBox_Login.Background = Brushes.Transparent;
                TextBox_Password1.ToolTip = "";
                TextBox_Password1.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Password == password1).FirstOrDefault();
                }

                if (authUser != null)
                {
                   
                    MainWindow mainWindow = new MainWindow();
                    
                    mainWindow.Show();
                }
                else
                    MessageBox.Show("Your login or password is invalid");


            }
        }



        private void Button_Window_Reg_Click(object sender, RoutedEventArgs e)
        {

            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            Hide();

        }
    }
}
