using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace APT
{
    public static class Database
    {
        public static NpgsqlConnection OtvoriNovuVezu()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=projekt;UserId=postgres;Password=postgres;ApplicationName=APT;");
            connection.Open();
            return connection;
        }
        public static void RegistrirajSe(string ime, string prezime, string email, string hashLozinka, DateTime terminPoroda)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO mama (ime, prezime, email, hash_lozinke, termin_poroda) VALUES " +
                    "('" + ime + "', '" + prezime + "', '" + email + "', '" + hashLozinka + "', '" + terminPoroda + "')";
            command.ExecuteNonQuery();
            veza.Close();
        }

        public static void AzurirajBiljesku(int id, string biljeska)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE biljeska SET biljeska = '" + biljeska + "' WHERE id='" +id +"';";
            command.ExecuteNonQuery();
            veza.Close();
        }


        public static void AzurirajVrijemeLogout()
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE dnevnik_login_logout SET vrijeme_logout = CURRENT_TIMESTAMP;";
            command.ExecuteNonQuery();
            veza.Close();
        }



        public static void ObrisiBiljesku(int id)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM biljeska WHERE id='" + id + "';";
            command.ExecuteNonQuery();
            veza.Close();
        }


        public static void SpremiNoviLogin()
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO dnevnik_login_logout (id_mame) VALUES ('" + Mama.id + "')";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }






        public static void SpremiTrud(int id_bol, string datum, string vrijeme, int trajanje)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO trud (id_mame,  datum, vrijeme, id_bol, trajanje) VALUES ('" + Mama.id + "','" + datum + "','" + vrijeme + "','" + id_bol + "','" +  trajanje + "')";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }

        public static void ObrisiPomak(int id)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM pomak WHERE id='" + id + "';";
            command.ExecuteNonQuery();
            veza.Close();
        }

        public static DataTable DohvatiSvePomakeMameNaDatum(DateTime datum)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT p.id, p.vrijeme, p.datum from pomak p WHERE p.id_mame=" + Mama.id + " AND p.datum='" + datum.Date + "';";
            NpgsqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            veza.Close();
            return dt;
        }




        public static void SpremiBilljesku(string biljeska, DateTime datum)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO biljeska (id_mame, vrijeme_kreiranja, biljeska) VALUES ('" + Mama.id + "','" + datum  + "','" + biljeska + "');";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }

        public static DataTable DohvatiSveBiljeskeBMameNaDatum(DateTime datum)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM biljeska WHERE id_mame=" + Mama.id + " AND vrijeme_kreiranja::date='" + datum.Date + "';";
            NpgsqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            veza.Close();
            return dt;
        }

        public static void SpremiPomak(DateTime datum, DateTime vrijeme)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO pomak (id_mame, datum, vrijeme) VALUES ('" + Mama.id + "','" + datum + "','" + vrijeme + "')";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }

        public static bool PrijaviSe (string email, string lozinka)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM mama WHERE email = '" + email + "';";
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (EnkripcijaLozinke.ProvjeriLozinku(lozinka, dr["hash_lozinke"].ToString()) == true)
                {
                    Mama.id = int.Parse(dr["id"].ToString());
                    Mama.ime = dr["ime"].ToString();
                    Mama.prezime = dr["prezime"].ToString();
                    Mama.email = dr["email"].ToString();
                    Mama.prezime = dr["prezime"].ToString();
                    Mama.terminPoroda = DateTime.Parse(dr["termin_poroda"].ToString());
                    AzurirajZadnjiLogin();
                    veza.Close();
                    return true;
                } 
            }
            veza.Close();
            return false;
        }

        public static void ObrisiTrud(int id)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM simptom_mama WHERE id= " + id + ";";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {

                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }

        public static void AzurirajZadnjiLogin()
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE mama SET zadnji_login=CURRENT_TIMESTAMP+interval '9 hours' WHERE email = '" + Mama.email + "' RETURNING *;";
            NpgsqlDataReader dr = command.ExecuteReader();
            dr.Read();
            Mama.zadnjiLogin = DateTime.Parse(dr["zadnji_login"].ToString());
            veza.Close();
        }


        public static void DohvatiSveSimptome()
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM simptom ORDER BY id ASC;";
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Simptom.dodajSimptom(dr["naziv"].ToString());
            }
            veza.Close();
        }


        public static DataTable DohvatiSveTrudoveMameNaDatum(DateTime datum)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT t.id, t.trajanje, t.vrijeme, t.datum, b.bol from trud t, bol b WHERE t.id_bol=b.id AND t.id_mame=" + Mama.id + " AND t.datum='" + datum.Date + "';";
            NpgsqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            veza.Close();
            return dt;
        }

        public static DataTable DohvatiSveSimptomeMameNaDatum(DateTime datum)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT s.naziv, sm.datum, s.id FROM simptom_mama sm, simptom s WHERE sm.id_mame="+ Mama.id + "AND sm.id_simptom=s.id and sm.datum= '" + datum + "';";
            NpgsqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            veza.Close();
            return dt;
        }


        public static void ObrisiSimptomMame(DateTime datum, int id_simptom)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM simptom_mama WHERE datum='" + datum + "' AND id_simptom= " + id_simptom + ";";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {

                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }

        public static void SpremiSimptomMame(DateTime datum, int id_simptom)
        {
            NpgsqlConnection veza = OtvoriNovuVezu();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO simptom_mama (id_mame, datum, id_simptom) VALUES ('"+ Mama.id + "','" + datum + "','" + id_simptom + "')";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
            veza.Close();
        }
    }
}
