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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {

        ApplicationContext db;
        public SignUpWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBox_Login.Text.Trim();
            string password1 = TextBox_Password1.Password.Trim();
            string password2 = TextBox_Password2.Password.Trim();
            string email = TextBox_Email.Text.Trim().ToLower();

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
            else if (password1 != password2)
            {
                TextBox_Password2.ToolTip = "Invalid password!";
                TextBox_Password2.Background = Brushes.DarkRed;
            }

            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBox_Email.ToolTip = "Invalid input!";
                TextBox_Email.Background = Brushes.DarkRed;
            }
            else
            {

                TextBox_Login.ToolTip = "";
                TextBox_Login.Background = Brushes.Transparent;
                TextBox_Password1.ToolTip = "";
                TextBox_Password1.Background = Brushes.Transparent;
                TextBox_Password2.ToolTip = "";
                TextBox_Password2.Background = Brushes.Transparent;
                TextBox_Email.ToolTip = "";
                TextBox_Email.Background = Brushes.Transparent;
                

                User user = new User(login, email, password1);
                db.Users.Add(user);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();
            }
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
           
        }


    }
}
