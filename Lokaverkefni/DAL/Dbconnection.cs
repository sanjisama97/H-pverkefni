using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class Dbconnection
    {
        public MySqlConnection con = new MySqlConnection("server=tsuts.tskoli.is;uid=1911952219;pwd='mypassword';database=1911952219_lokaverkefni_user");
        public MySqlConnection getCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int ExeNonQuery(MySqlCommand cmd)
        {
            cmd.Connection = getCon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        public object ExeScaler(MySqlCommand cmd)
        {
            cmd.Connection = getCon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        public DataTable ExeReader(MySqlCommand cmd)
        {
            cmd.Connection = getCon();
            MySqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;


        }
    }
}
