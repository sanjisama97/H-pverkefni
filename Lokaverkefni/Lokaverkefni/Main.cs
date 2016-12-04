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
    public partial class MainPage : Form
    {

        RegisterForm formInstance = new RegisterForm();

        public Informations info = new Informations();
        public Operations opr = new Operations();
        DataTable dt = new DataTable();
        public MainPage()
        {
            InitializeComponent();
        }
       











       


        private void btMainRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstance.ShowDialog();
            this.Close();

            

            
            
            }

        public void btMainLogin_Click(object sender, EventArgs e)
        {
            string username = txtMainUsername.Text;
            string password = txtMainPassword.Text;
            info.username = username;
            info.password = password;
            
        
            
            

            dt = opr.login(info);

            if(dt.Rows.Count > 0)
            {
                
                ApplicationLayer app = new ApplicationLayer();
                app.Show();
                app.txtUser.Text = username;
                
               



            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
        }

        
    }

