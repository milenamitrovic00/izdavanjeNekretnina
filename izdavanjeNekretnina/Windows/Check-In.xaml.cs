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
using System.Data.SQLite;
using System.Data;
using izdavanjeNekretnina.Windows.NotifyUser;

namespace izdavanjeNekretnina.Windows
{
    /// <summary>
    /// Interaction logic for Check_In.xaml
    /// </summary>
    public partial class Check_In : UserControl
    {
        public Check_In()
        {
            InitializeComponent();
        }

        private void BtnRent(object sender, RoutedEventArgs e) 
        {

            Gosti gosti = new Gosti();
            gosti.Ime = Name.Text;
            gosti.Prezime = Surname.Text;
            gosti.JMBG = ID.Text;
            gosti.BrojTelefona = PhoneNumber.Text;
            gosti.CheckIn = CheckIn.Text;
            gosti.CheckOut = CheckOut.Text;

            //Validacija
            var userValidator = new UserValidator();
            var result = userValidator.Validate(gosti);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    //errors.Add($"{faliure.PropertyName}: {faliure.ErrorMessage}");
                    MessageBox.Show(failure.ErrorMessage);
                }
            }
            else
            {
                SqlDataAccessGosti sqlDataAccess = new SqlDataAccessGosti();
                Obavestenje obavestenje = new Obavestenje();
                Obavestenje2 obavestenje2 = new Obavestenje2();

                if (sqlDataAccess.SaveUser(gosti))
                {

                    obavestenje.Show();
                }
                else
                {

                    obavestenje2.Show();
                }

            }

            ResetFields();

        }

        private void ResetFields()
        {
            Name.Text = null;
            Surname.Text = null;
            ID.Text = null;
            PhoneNumber.Text = null;
            CheckIn.Text = null;
            CheckOut.Text = null;
        }
    }
}
