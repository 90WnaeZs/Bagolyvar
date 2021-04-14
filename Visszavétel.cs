using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Vezeteknev_Keresztnev_Gepszam
{
    public partial class Visszavétel : Form
    {
        DB db;
        int kolcsonzoID = 0;
        int peldany = 0;
        string konyv_kod = "";
        string datum = "";
        public void bérlő_Feltöltés()
        {
            string QUERY_SELECT_berlo = "SELECT DISTINCT(kolcsonzo.nev) FROM kolcsonzo JOIN kolcsonzes ON kolcsonzo.ID=kolcsonzes.kolcsonzoID WHERE kolcsonzes.peldany>0";
            
            using (MySqlCommand CMD_SELECT_berlo=new MySqlCommand(QUERY_SELECT_berlo,db.conn))
            {
                if(db.conn.State==ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                MySqlDataReader READER_SELECT_berlo = CMD_SELECT_berlo.ExecuteReader();
                while (READER_SELECT_berlo.Read())
                {
                    combo_berlo.Items.Add(READER_SELECT_berlo.GetString("nev"));
                }
                READER_SELECT_berlo.Close();
                db.conn.Close();
            }
        }

        public void könyv_Listázás()
        {
            string nev = combo_berlo.Text.Trim();
            string QUERY_SELECT_kolcsonzoID = "SELECT ID FROM kolcsonzo WHERE nev=@kolcsonzonev";
            string QUERY_SELECT_konyvek = "SELECT * FROM konyvek JOIN kolcsonzes ON konyvek.Kod=kolcsonzes.konyvID WHERE kolcsonzes.kolcsonzoID=@kolcsonzoID";
            string QUERY_SELECT_peldany = "SELECT peldany FROM kolcsonzes WHERE kolcsonzoID=@kolcsID AND konyvID=@konyvID";
            if(db.conn.State==ConnectionState.Closed)
            {
                db.conn.Open();
            }
            using (MySqlCommand CMD_SELECT_kolcsonzoID=new MySqlCommand(QUERY_SELECT_kolcsonzoID,db.conn))
            using (MySqlCommand CMD_SELECT_konyvek = new MySqlCommand(QUERY_SELECT_konyvek, db.conn))
            using (MySqlCommand CMD_SELECT_peldany = new MySqlCommand(QUERY_SELECT_peldany, db.conn))
            {
                CMD_SELECT_kolcsonzoID.Parameters.Add("@kolcsonzonev", MySqlDbType.VarChar).Value = nev;
                MySqlDataReader READER_SELECT_koncsonzoID = CMD_SELECT_kolcsonzoID.ExecuteReader();
                while (READER_SELECT_koncsonzoID.Read())
                {
                    kolcsonzoID = Convert.ToInt32(READER_SELECT_koncsonzoID.GetString("ID"));
                }
                READER_SELECT_koncsonzoID.Close();

                CMD_SELECT_konyvek.Parameters.Add("@kolcsonzoID", MySqlDbType.VarChar).Value = kolcsonzoID;
                MySqlDataReader READER_SELECT_konyvek = CMD_SELECT_konyvek.ExecuteReader();
                while (READER_SELECT_konyvek.Read())
                {
                    listBox1.Items.Add(nev+" -> "+ READER_SELECT_konyvek.GetString("Szerzo")+":"+ READER_SELECT_konyvek.GetString("Cím")+" ("+ READER_SELECT_konyvek.GetString("peldany") + "db)");
                    
                }
                READER_SELECT_konyvek.Close();
            }
        }

        private void könyv_adatok()
        {
            if(db.conn.State==ConnectionState.Closed)
            {
                db.conn.Open();
            }
            string[] tomb1 = listBox1.SelectedItem.ToString().Split(new string[] { " -> " }, StringSplitOptions.None);
            string[] tomb2 = tomb1[1].ToString().Split(new string[] { ":" }, StringSplitOptions.None);
            string[]tomb3= tomb2[1].ToString().Split(new string[] { " (" }, StringSplitOptions.None);
            tbx_szerzo.Text = tomb2[0];
            tbx_konyv.Text = tomb3[0];
            num_peldany.Value = Convert.ToInt32(tomb3[1].Trim('d','b',')'));
            string isbn = "";
            string QUERY_SELECT_isbn = "SELECT ISBN FROM konyvek WHERE Cím=@cim";
            using (MySqlCommand CMD_SELECT_isbn = new MySqlCommand(QUERY_SELECT_isbn, db.conn))
            {
                CMD_SELECT_isbn.Parameters.Add("@cim",MySqlDbType.VarChar).Value = tbx_konyv.Text;
                MySqlDataReader READER_SELECT_isbn = CMD_SELECT_isbn.ExecuteReader();
                while (READER_SELECT_isbn.Read())
                {
                    isbn = READER_SELECT_isbn.GetString("ISBN");
                }
                READER_SELECT_isbn.Close();
            }
            tbx_isbn.Text = isbn;

            string nev = combo_berlo.Text.Trim();
            string QUERY_SELECT_kolcsonzoID = "SELECT ID FROM kolcsonzo WHERE nev=@kolcsonzonev";
            string QUERY_SELECT_konyvek = "SELECT * FROM konyvek JOIN kolcsonzes ON konyvek.Kod=kolcsonzes.konyvID WHERE kolcsonzes.kolcsonzoID=@kolcsonzoID";
            string QUERY_SELECT_datum = "SELECT kivetelDatum FROM kolcsonzes WHERE kolcsonzoID=@kolcsID AND konyvID=@konyvID";
            using (MySqlCommand CMD_SELECT_kolcsonzoID = new MySqlCommand(QUERY_SELECT_kolcsonzoID, db.conn))
            using (MySqlCommand CMD_SELECT_konyvek = new MySqlCommand(QUERY_SELECT_konyvek, db.conn))
            using (MySqlCommand CMD_SELECT_datum = new MySqlCommand(QUERY_SELECT_datum, db.conn))
            {
                CMD_SELECT_kolcsonzoID.Parameters.Add("@kolcsonzonev", MySqlDbType.VarChar).Value = nev;
                MySqlDataReader READER_SELECT_koncsonzoID = CMD_SELECT_kolcsonzoID.ExecuteReader();
                while (READER_SELECT_koncsonzoID.Read())
                {
                    kolcsonzoID = Convert.ToInt32(READER_SELECT_koncsonzoID.GetString("ID"));
                }
                READER_SELECT_koncsonzoID.Close();

                CMD_SELECT_konyvek.Parameters.Add("@kolcsonzoID", MySqlDbType.VarChar).Value = kolcsonzoID;
                MySqlDataReader READER_SELECT_konyvek = CMD_SELECT_konyvek.ExecuteReader();
                while (READER_SELECT_konyvek.Read())
                {
                    konyv_kod=READER_SELECT_konyvek.GetString("Kod");
                }
                READER_SELECT_konyvek.Close();

                CMD_SELECT_datum.Parameters.Add("@kolcsID", MySqlDbType.Int32).Value = kolcsonzoID;
                CMD_SELECT_datum.Parameters.Add("@konyvID", MySqlDbType.VarChar).Value = konyv_kod;
                MySqlDataReader READER_SELECT_datum = CMD_SELECT_datum.ExecuteReader();
                while (READER_SELECT_datum.Read())
                {
                    datum = READER_SELECT_datum.GetString("kivetelDatum");
                }
                READER_SELECT_datum.Close();
            }
            lbl_date.Text = datum+" ("+(DateTime.Now - DateTime.Parse(datum)).TotalDays+" nap)";
        }
        public Visszavétel()
        {
            InitializeComponent();
            db = new DB();
            db.Csatlakozas();
            bérlő_Feltöltés();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            könyv_Listázás();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            könyv_adatok();
        }

        private void btn_Visszaad_Click(object sender, EventArgs e)
        {
            if (db.conn.State == ConnectionState.Closed)
            {
                db.conn.Open();
            }
            string nev = combo_berlo.Text.Trim();
            string QUERY_SELECT_kolcsonzoID = "SELECT ID FROM kolcsonzo WHERE nev=@kolcsonzonev";
            string QUERY_SELECT_konyvek = "SELECT * FROM konyvek JOIN kolcsonzes ON konyvek.Kod=kolcsonzes.konyvID WHERE kolcsonzes.kolcsonzoID=@kolcsonzoID";
            string QUERY_DELETE_datum = "DELETE FROM kolcsonzes WHERE kolcsonzoID=@kolcsID AND konyvID=@konyvID";
            using (MySqlCommand CMD_SELECT_kolcsonzoID = new MySqlCommand(QUERY_SELECT_kolcsonzoID, db.conn))
            using (MySqlCommand CMD_SELECT_konyvek = new MySqlCommand(QUERY_SELECT_konyvek, db.conn))
            using (MySqlCommand CMD_DELETE_kolcsonzes = new MySqlCommand(QUERY_DELETE_datum, db.conn))
            {
                CMD_SELECT_kolcsonzoID.Parameters.Add("@kolcsonzonev", MySqlDbType.VarChar).Value = nev;
                MySqlDataReader READER_SELECT_koncsonzoID = CMD_SELECT_kolcsonzoID.ExecuteReader();
                while (READER_SELECT_koncsonzoID.Read())
                {
                    kolcsonzoID = Convert.ToInt32(READER_SELECT_koncsonzoID.GetString("ID"));
                }
                READER_SELECT_koncsonzoID.Close();

                CMD_SELECT_konyvek.Parameters.Add("@kolcsonzoID", MySqlDbType.VarChar).Value = kolcsonzoID;
                MySqlDataReader READER_SELECT_konyvek = CMD_SELECT_konyvek.ExecuteReader();
                while (READER_SELECT_konyvek.Read())
                {
                    konyv_kod = READER_SELECT_konyvek.GetString("Kod");
                }
                READER_SELECT_konyvek.Close();

                CMD_DELETE_kolcsonzes.Parameters.Add("@kolcsID", MySqlDbType.Int32).Value = kolcsonzoID;
                CMD_DELETE_kolcsonzes.Parameters.Add("@konyvID", MySqlDbType.VarChar).Value = konyv_kod;
                if(CMD_DELETE_kolcsonzes.ExecuteNonQuery()>1)
                {
                    MessageBox.Show("Sikeres törlés!");
                    listBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nem sikerült a törlés!");
                }
            }
        }
    }
}
