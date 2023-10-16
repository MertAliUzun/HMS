using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        SecretaryForm secForm = new SecretaryForm();
        DoctorForm docForm = new DoctorForm();
        public static int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 34, 36, 49);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            this.connection = DataAccess.Connection;
            string userName = textBoxLoginName.Text;
            string password = textBoxLoginPassword.Text;
            if (LoginHandler.VerifyLogin(userName, password, doc))
            {
                MessageBox.Show("Succesful Login");
                if (LoginHandler.isDoctor)
                {
                    id = doc.doctorID;
                    MessageBox.Show("Login as Doctor");
                    docForm.Show();
                    this.Hide();

                }else
                {
                    MessageBox.Show("Login as Secretary");
                    secForm.Show();
                    //SecretaryForm sf = new SecretaryForm();
                    this.Hide();
                    //sf.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
