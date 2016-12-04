using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lokaverkefni
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
    }
}
