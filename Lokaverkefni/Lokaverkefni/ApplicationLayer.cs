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
        DataTable dt = new DataTable();
        MainPage mainform = new MainPage();
       


        public ApplicationLayer()
        {
            InitializeComponent();
        }


        



        public void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string title = movieTitle.Text;
            string rating = comboRaiting.Text;
            string genre = genreTxt.Text;
            string status = "ok";
            if (radioButton1.Checked == true)
            {
                status = "Finished watching";
            }
            if (radioButton2.Checked == true)
            {
                status = "Plan to watch";
            }

            info.username = username;
            info.title = title;
            info.raiting = rating;
            info.genre = genre;
            info.status = status;
            if (title == "" || rating == "" || genre == "" || status == "")
            {
                MessageBox.Show("You need to fill everything in");
            }
            else
            {
                int rows = opr.insertMovie(info);
                MessageBox.Show("You have successfully entered the movie into the database for " + info.username);
            }


            DataTable dt = new DataTable();
            dt = opr.getMovies(info);
            dgvMovies.DataSource = dt;

            
           








        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = txtUser.Text;
            info.username = username;

           
        }
    }
}
