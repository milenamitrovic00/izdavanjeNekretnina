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

namespace izdavanjeNekretnina.Windows.NotifyUser
{
    /// <summary>
    /// Interaction logic for GreskaPovezivanjaBaze.xaml
    /// </summary>
    public partial class GreskaPovezivanjaBaze : Window
    {
        public GreskaPovezivanjaBaze()
        {
            InitializeComponent();
        }

        private void Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
