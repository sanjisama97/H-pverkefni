using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lokaverkefni
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string myConnectionString = "server=tsuts.tskoli.is;uid=1911952219;pwd='mypassword';database=1911952219_lokaverkefni_user;";
       
        

        RegisterForm formInstance = new RegisterForm();

        private void Main_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    txtMainUsername.Text = "yeeboi";
                }
                else
                {
                    txtMainUsername.Text = "fail";
                }
            }

        }


        private void btMainRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstance.ShowDialog();
            this.Close();
        }

        
    }
}
