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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace izdavanjeNekretnina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
         
        }
        private void BtnMin(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Minimized;
            }
        }
        private void BtnMax(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            
        }

        private void Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BtnWeb(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://airbnb.rs/");
        }

        public void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Check_In());
                    break;
                case 1:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Maintenence());
                    break;
                case 2:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Payment());
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TransitionEffect.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (250 + (60 * index)), 0, 0);
        }


        private void btnOpen(object sender, RoutedEventArgs e) {

            GridUserControl.Children.Clear();
            GridUserControl.Children.Add(new Windows.Maintenence());
        }

        private void BtnHelp(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Users\\Milena\\OneDrive\\Desktop\\izdavanjeNekretnina\\izdavanjeNekretnina\\Help\\res\\Help.chm");
        }
    }
}
