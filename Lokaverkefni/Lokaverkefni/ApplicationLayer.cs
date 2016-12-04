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
    public partial class ApplicationLayer : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        public ApplicationLayer()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            string fullname = info.firstname + " " + info.lastname;
            string email = info.email;
            string username = info.email;
            string gender = info.gender;
            DataTable dt = new DataTable();
            dt = opr.login(info);

            MessageBox.Show(opr.returnUser);

        }
    }
}
