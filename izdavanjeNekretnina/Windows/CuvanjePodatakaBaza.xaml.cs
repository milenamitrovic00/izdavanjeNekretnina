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

namespace izdavanjeNekretnina.Windows
{
    /// <summary>
    /// Interaction logic for CuvanjePodatakaBaza.xaml
    /// </summary>
    public partial class CuvanjePodatakaBaza : Window
    {
        public CuvanjePodatakaBaza()
        {
            InitializeComponent();
            LoadGosti();
        }

        private void LoadGosti()
        {
            DataGridGosti.ItemsSource = Global.DSglobal.Tables[0].DefaultView;
        }
    }
}
