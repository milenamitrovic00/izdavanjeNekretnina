using izdavanjeNekretnina.Windows.NotifyUser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace izdavanjeNekretnina.Windows
{

    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }
        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            

            TextBox.Focus();
        }


        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            string username, password;

            username = TextBox.Text;
            password = PasswordBox.Password;
            MainWindow mainWindow = new MainWindow();
            Error error = new Error();

            if (username == "Admin" && password == "Admin" )
            {
                mainWindow.Show();
                Close();

            }
            else
            {
                error.Show();

            }
        }

        private void BtnHelp(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Users\\Milena\\OneDrive\\Desktop\\izdavanjeNekretnina\\izdavanjeNekretnina\\Help\\res\\Help.chm");
        }
    }
}
