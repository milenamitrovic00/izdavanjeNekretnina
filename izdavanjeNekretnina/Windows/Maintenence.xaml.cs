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
using System.Data.SqlClient;

namespace izdavanjeNekretnina.Windows
{
    /// <summary>
    /// Interaction logic for Maintenence.xaml
    /// </summary>
    public partial class Maintenence : UserControl
    {

        public Maintenence()
        {
            InitializeComponent();
            LoadGosti();

        }

        public void LoadGosti()
        {

            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=Gosti.db; version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Gosti";
                SQLiteDataAdapter DA = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    DataGridGosti.ItemsSource = DS.Tables[0].DefaultView;
                }

                Global.DSglobal = DS;

            }
            catch
            {
                CuvanjePodatakaBaza cuvanjePodatakaBaza = new CuvanjePodatakaBaza();
                cuvanjePodatakaBaza.Show();

            }


        }
        private void btnSaveChanges(object sender, RoutedEventArgs e)
        {
            //Windows.CuvanjePodatakaBaza Save = new Windows.CuvanjePodatakaBaza();
            //Save.ShowDialog();

            }
       


            private void btnDelete(object sender, RoutedEventArgs e)
        {

            DataRowView datarow = DataGridGosti.SelectedItem as DataRowView;
            if (datarow != null)
            {

                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataView dataView = DataGridGosti.ItemsSource as DataView;
                    dataView.Table.Rows.Remove(datarow.Row);
                    
                    System.Windows.MessageBox.Show("Record succesfully Deleted");


                }

                else {

                    System.Windows.MessageBox.Show("Delete operation Terminated");

                }
            }
        }
    }

}
