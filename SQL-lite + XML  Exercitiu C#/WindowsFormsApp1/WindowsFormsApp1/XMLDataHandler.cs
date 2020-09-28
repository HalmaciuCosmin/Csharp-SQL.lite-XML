using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    class XMLDataHandler
    {
        Database data = new Database();
        string a, b, c;

        public void Import()
        {


            XmlTextReader reader = new XmlTextReader("Fisier.xml");
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            XmlReader.Create(reader, settings);

            string st = "DROP TABLE user";
            SQLiteCommand comanda = new SQLiteCommand(st, data.conexiune);
            comanda.ExecuteNonQuery();

            string st1 = "create table user (Nume varchar(20), Prenume varchar(20), CNP varchar(20))";
            SQLiteCommand comanda2 = new SQLiteCommand(st1, data.conexiune);
            comanda2.ExecuteNonQuery();



            while (reader.Read())
            {
                a = null;
                b = null;
                c = null;



                if (reader.NodeType == XmlNodeType.Text)
                {
                    a = reader.Value;
                    reader.Read();

                    while (reader.NodeType != XmlNodeType.Text)
                    {
                        reader.Read();
                    }

                    b = reader.Value;
                    reader.Read();

                    while (reader.NodeType != XmlNodeType.Text)
                    {
                        reader.Read();
                    }

                    c = reader.Value;
                }

                string st2 = "INSERT INTO user(Nume, Prenume,  CNP) VALUES ('" + a + "', '" + b + "', '" + c + "')";
                SQLiteCommand command1 = new SQLiteCommand(st2, data.conexiune);
                if (a != null && b != null && c != null) command1.ExecuteNonQuery();
            }
            reader.Close();
        }

        public void Export()
        {
           

            string st = "SELECT * FROM user";
            SQLiteCommand command = new SQLiteCommand(st, data.conexiune);
            SQLiteDataReader reader = command.ExecuteReader();

            XmlTextWriter writer = new XmlTextWriter("Fisier.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement("ListaPers");

            while (reader.Read())
            {
                a = reader[0].ToString();
                b = reader[1].ToString();
                c = reader[2].ToString();

                writer.WriteStartElement("Persoana");
                writer.WriteStartElement("Nume");
                writer.WriteString(a);
                writer.WriteEndElement();
                writer.WriteStartElement("Prenume");
                writer.WriteString(b);
                writer.WriteEndElement();
                writer.WriteStartElement("CNP");
                writer.WriteString(c);
                writer.WriteEndElement();
                writer.WriteEndElement();

            }

            writer.WriteEndElement();
            writer.Close();
        }


    }
}
           
 
    
