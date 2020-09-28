using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Database Baza = new Database();
        XMLDataHandler Xml = new XMLDataHandler();

        public Form1()
        {        
            InitializeComponent();
            afisare();
        }

        private void Conectare_Click(object sender, EventArgs e)
        {     
            MessageBox.Show(Baza.Conectare());
            afisare();
        }



        private void Deconectare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Baza.Deconectare());
            
        }



        private void Inserare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Baza.Inserare(Nume.Text, Prenume.Text, CNP.Text));
            afisare();
        }



        private void Stergere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Baza.Stergere(Modificare.Text));
            afisare();
        }

       

        private void Actualizare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Baza.Actualizare(Nume.Text,Prenume.Text,CNP.Text,Modificare.Text));
            afisare();
        }

        private void Cautare_Click(object sender, EventArgs e)
        {
            string st1 = "SELECT * FROM user WHERE Nume = '" + Modificare.Text + "' ";
            SQLiteCommand comanda = new SQLiteCommand(st1, Baza.conexiune);


            SQLiteDataAdapter adaptor = new SQLiteDataAdapter();
            adaptor.SelectCommand = comanda;
            DataTable table = new DataTable();
            adaptor.Fill(table);


            dataGridView1.DataSource = table;
            adaptor.Update(table);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            afisare();
       }


        private void afisare()
        {
            string st1 = "select * from user";
            SQLiteCommand comanda = new SQLiteCommand(st1, Baza.conexiune);


            SQLiteDataAdapter adaptor = new SQLiteDataAdapter();
            adaptor.SelectCommand = comanda;
            DataTable table = new DataTable();
            adaptor.Fill(table);


            dataGridView1.DataSource = table;
            adaptor.Update(table);
        }

        private void Import_XML_Click(object sender, EventArgs e)
        {
            Xml.Import();
            MessageBox.Show("Import reusit");
            afisare();
        }

        private void Export_XML_Click(object sender, EventArgs e)
        {
            Xml.Export();
            MessageBox.Show("Export reusit");
        }
    }

}
