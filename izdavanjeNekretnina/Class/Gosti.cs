using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Gosti
    {

    public Gosti() { }

    public Gosti(string ime, string prezime, string jMBG, string brojTelefona, string checkIn, string checkOut, int id)
    {

        ID = id;

        Ime = ime;
        Prezime = prezime;
        JMBG = jMBG;
        BrojTelefona = brojTelefona;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int ID { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string JMBG { get; set; }
    public string BrojTelefona { get; set; }
    public string CheckIn { get; set; }
    public string CheckOut { get; set; }

    internal static SqlConnection GetConnection()
    {
        throw new NotImplementedException();
    }
}


