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
    public partial class Kölcsönző : Form
    {
        DB db;
        private void konyv_Feltoltes()
        {
            try
            {
                db.Csatlakozas();

                string QUERY_SELECT_könyv = "SELECT * FROM konyvek";

                using (MySqlCommand CMD_konyv_feltoltes = new MySqlCommand(QUERY_SELECT_könyv, db.conn))
                using (MySqlDataReader READER_konyv_feltoltes = CMD_konyv_feltoltes.ExecuteReader())
                {
                    if(db.conn.State==ConnectionState.Closed)
                    {
                        db.conn.Open();
                    }
                    while (READER_konyv_feltoltes.Read())
                    {
                        könyv_combo.Items.Add(READER_konyv_feltoltes.GetString("Szerzo") + ":" + READER_konyv_feltoltes.GetString("Cím"));
                    }
                }
                db.conn.Close();
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
            }
            
        }

        private void berlo_Feltoltes()
        {
            try
            {
                db.Csatlakozas();

                string QUERY_SELECT_berlo = "SELECT * FROM kolcsonzo";

                using (MySqlCommand CMD_berlo_feltoltes = new MySqlCommand(QUERY_SELECT_berlo, db.conn))
                using (MySqlDataReader READER_berlo_feltoltes = CMD_berlo_feltoltes.ExecuteReader())
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();
                    }
                    while (READER_berlo_feltoltes.Read())
                    {
                        bérlő_combo.Items.Add(READER_berlo_feltoltes.GetString("nev"));
                    }
                }
                db.conn.Close();
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
            }
        }

        public Kölcsönző()
        {
            InitializeComponent();
            db = new DB();
            db.Csatlakozas();
            konyv_Feltoltes();
            berlo_Feltoltes();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(bérlő_combo.Text+" -> "+könyv_combo.Text +" ("+ peldany.Value+" db)");
        }

        private void btn_Rögzít_Click(object sender, EventArgs e)
        {
            db.Csatlakozas();
            string berlo = "";
            string konyv = "";
            string peldany = "";
            string berloID = "";
            string konyvID = "";

            string QUERY_SELECT_berloID = "SELECT ID from kolcsonzo WHERE nev=@nev";
            string QUERY_SELECT_konyvID = "SELECT Kod from konyvek WHERE Cím=@cim";
            string QUERY_INSERT_kolcsonzes = "INSERT INTO kolcsonzes (konyvID,kolcsonzoID,kivetelDatum,peldany) VALUES(@konyvid,@kolcsonzoid,@kiveteldatum,@peldany)";

            List<string> berlo_list = new List<string>();
            List<string> konyv_list = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string currentItem = listBox1.Items[i].ToString();
                string[] tomb1 = currentItem.Split(new string[] { " -> " }, StringSplitOptions.None);
                string[] tomb2 = currentItem.Split(new string[] { ":" }, StringSplitOptions.None);
                string[]tomb3= tomb2[1].Split(new string[] { " (" }, StringSplitOptions.None);
                string[]tomb4=tomb3[1].Split(new string[] { " db)" }, StringSplitOptions.None);

                berlo = tomb1[0].Trim();
                konyv = tomb3[0].Trim();
                peldany = tomb4[0].Trim();

                peldany.Replace("db)", "").Trim();
                MessageBox.Show(peldany);
                using (MySqlCommand CMD_SELECT_berloID=new MySqlCommand(QUERY_SELECT_berloID,db.conn))
                using (MySqlCommand CMD_SELECT_konyvID = new MySqlCommand(QUERY_SELECT_konyvID, db.conn))
                using (MySqlCommand CMD_INSERT_kolcsonzes = new MySqlCommand(QUERY_INSERT_kolcsonzes, db.conn))
                {
                    CMD_SELECT_berloID.Parameters.Add("@nev",MySqlDbType.VarChar).Value = berlo;
                    CMD_SELECT_konyvID.Parameters.Add("@cim", MySqlDbType.VarChar).Value = konyv;

                    MySqlDataReader READER_SELECT_berloID = CMD_SELECT_berloID.ExecuteReader();
                    while (READER_SELECT_berloID.Read())
                    {
                        berloID = READER_SELECT_berloID.GetString("ID");
                    }
                    READER_SELECT_berloID.Close();

                    MySqlDataReader READER_SELECT_konyvID = CMD_SELECT_konyvID.ExecuteReader();
                    while (READER_SELECT_konyvID.Read())
                    {
                        konyvID = READER_SELECT_konyvID.GetString("Kod");
                    }
                    READER_SELECT_konyvID.Close();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    //string date = DateTime.Now.ToShortDateString();
                    //@konyvid,@kolcsonzoid,@kiveteldatum,@peldany
                    CMD_INSERT_kolcsonzes.Parameters.Add("@konyvid", MySqlDbType.VarChar).Value = konyvID;
                    CMD_INSERT_kolcsonzes.Parameters.Add("@kolcsonzoid", MySqlDbType.Int32).Value = Convert.ToInt32(berloID);
                    CMD_INSERT_kolcsonzes.Parameters.Add("@kiveteldatum", MySqlDbType.VarChar).Value = date;
                    CMD_INSERT_kolcsonzes.Parameters.Add("@peldany", MySqlDbType.Int32).Value = Convert.ToInt32(peldany);

                    if(CMD_INSERT_kolcsonzes.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Sikeres rögzítés!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen rögzítés!");
                    }
                }
            }
            
        }
    }
}
