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
    public partial class RegisterForm : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        string gender;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void btRegiSubmit_Click(object sender, EventArgs e)
        {
            // Nýjar breytur sem taka gildi úr textboxum og eru síðan notaðir í samræmi við information layerið
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            info.firstname = firstname;
            info.lastname = lastname;
            info.email = email;
            info.username = username;
            info.password = password;
            //Chceck box sem vistar gender sem annaðhvort male eða female
            if (genderMale.Checked == true)
            {
                gender = "Male";
            }
            if (genderFemale.Checked == true)
            {
                gender = "Female";
            }
            info.gender = gender;

            if (firstname != "" && lastname != "" && email.Contains("@") && email.Contains("."))
            {
                if (password.Length >= 5 && username.Length >= 5)
                {

                    int rows = opr.insertUser(info);
                    if (rows > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Either your password or your username is not long enough, both have to extend at least 5 characters");
                }
            }
            else
            {
                MessageBox.Show("Error!! Make sure all textboxes are filled and that the email is legit");

            }
        }
            
            
            

            

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
