using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using reportCard.Properties;

namespace reportCard
{
    class Functions
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=" + Settings.Default.Server + ";Port=" + Settings.Default.Port + ";Database=" + Settings.Default.Database + ";Uid=" + Settings.Default.Username + ";Pwd=" + Settings.Default.Password + ";";
            }
        }

        public static bool TestConnection()
        {
            bool _return = true;

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    _return = false;
                }
            }

            return _return;
        }
        public static DataTable DataTable(string sql)
        {
            DataTable _table = new DataTable();
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlDataAdapter adp = new MySqlDataAdapter(sql, con))
                {
                    adp.Fill(_table);
                }
            }

            return _table;
        }
        internal static DataTable DataTable(object _sql)
        {
            throw new NotImplementedException();
        }
    }
}