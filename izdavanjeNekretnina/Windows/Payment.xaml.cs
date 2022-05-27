using izdavanjeNekretnina.Windows.NotifyUser;
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

namespace izdavanjeNekretnina.Windows
{
    /// <summary>
    /// Interaction logic for Payroll.xaml
    /// </summary>
    public partial class Payment : UserControl
    {
        int Rent;
        int Deposit;
        int Days;
        int total;



        public Payment()
        {

            InitializeComponent();
        }

        private void btnCalculate(object sender, RoutedEventArgs e)
        {
            CalculationError error = new CalculationError();

            try
            {

                Rent = Convert.ToInt32(RentTxt.Text);
                Deposit = Convert.ToInt32(DepositTxt.Text);
                Days = Convert.ToInt32(DaysTxt.Text);

                total = Days * (Rent + Deposit);

                Result.Content = total.ToString();

            }
            catch {

                error.Show();

            }
            

        }
    }
}
