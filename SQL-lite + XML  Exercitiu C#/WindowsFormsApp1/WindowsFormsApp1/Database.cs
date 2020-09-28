using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp1
{

   
    class Database
    {

        public SQLiteConnection conexiune;

        public  Database()
        {
            conexiune = new SQLiteConnection("Data source=baza_de_date.sqlite3");
            conexiune.Open();
            string cale = "baza_de_date.sqlite3";
            FileInfo fi = new FileInfo(cale);

            if (fi.Length == 0)
            {
                string st1 = "create table user (Nume varchar(20), Prenume varchar(20), CNP varchar(20))";
                SQLiteCommand comanda = new SQLiteCommand(st1, conexiune);
                comanda.ExecuteNonQuery();
            }

        }

        public string Conectare()
        {

            try
            {
                conexiune.Open();
                return "Conectare Reusita";               
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }

        public string Deconectare()
        {
            try
            {
                if (conexiune != null)
                {
                    conexiune.Close();
                    return "Deconectare reusita";
                }
                else
                {
                    return "Esti deja conectat";

                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
           
        }
            
    


        public string Inserare(string a, string b, string c)
        {
            string st2 = "INSERT INTO user(Nume, Prenume,  CNP) VALUES ('" + a + "', '" + b + "', '" + c + "')";
            SQLiteCommand command1 = new SQLiteCommand(st2, conexiune);
            command1.ExecuteNonQuery();
            return "Inserare reusita";
        }

        public string Stergere(string a)
        {
            string st2 = "DELETE FROM user WHERE Nume = '" + a + "' ";
            SQLiteCommand command1 = new SQLiteCommand(st2, conexiune);
            command1.ExecuteNonQuery();
            return "Stergere reusita";
        }

        public string Actualizare (string a, string b, string c, string d)
        {
            string st2 = "UPDATE user SET Nume = '" + a + "', Prenume = '" + b + "', CNP = '" + b + "' WHERE Nume = '" + d + "'";
            SQLiteCommand command1 = new SQLiteCommand(st2, conexiune);
            command1.ExecuteNonQuery();
            return "Actualizare reusita";
        }
     

      

    }

}
