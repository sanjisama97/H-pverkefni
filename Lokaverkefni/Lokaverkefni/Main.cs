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
using BAL;
using BEL;

namespace Lokaverkefni
{
    public partial class Main : Form
    {

        RegisterForm formInstance = new RegisterForm();

        public Informations info = new Informations();
        public Operations opr = new Operations();
        DataTable dt = new DataTable();
        public Main()
        {
            InitializeComponent();
        }

       
        

       
       



        

        private void Main_Load(object sender, EventArgs e)
        {
            

        }


        private void btMainRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstance.ShowDialog();
            this.Close();

            

            
            
            }

        private void btMainLogin_Click(object sender, EventArgs e)
        {
            string username = txtMainUsername.Text;
            string password = txtMainPassword.Text;
            info.username = username;
            info.password = password;

            opr.returnUser = username;

            

            dt = opr.login(info);

            if(dt.Rows.Count > 0)
            {
                ApplicationLayer app = new ApplicationLayer();
                app.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
        }

        
    }

