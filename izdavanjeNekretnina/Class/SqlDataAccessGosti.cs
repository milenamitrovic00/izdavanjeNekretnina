using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows;

class SqlDataAccessGosti
{
    public bool SaveUser(Gosti gosti)
    {
        SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=Gosti.db;Version=3;");
        if (sQLiteConnection.State == ConnectionState.Closed)
            sQLiteConnection.Open();

        try
        {

            String query = "insert into Gosti (Ime, Prezime, JMBG, BrojTelefona, CheckIn, CheckOut, ID)" +
                "values(" +
                "'" + gosti.Ime + "'," +
                "'" + gosti.Prezime + "'," +
                "'" + gosti.JMBG + "'," +
                "'" + gosti.BrojTelefona + "'," +
                "'" + gosti.CheckIn + "'," +
                "'" + gosti.CheckOut + "')" +
                "'" + gosti.ID + "')"; ;
            SQLiteCommand cmd = new SQLiteCommand(query, sQLiteConnection);
            cmd.ExecuteScalar();
            return true;


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
        finally
        {
            sQLiteConnection.Close();
        }

    }
}


