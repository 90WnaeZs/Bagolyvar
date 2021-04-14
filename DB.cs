using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Vezeteknev_Keresztnev_Gepszam
{
    class DB
    {
        public MySqlConnection conn;
        public void Csatlakozas()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = "localhost";
            db.Database = "bagolyvar";
            db.UserID = "root";
            db.Password = "";

            conn = new MySqlConnection(db.ToString());

            conn.Open();
        }
    }
}
