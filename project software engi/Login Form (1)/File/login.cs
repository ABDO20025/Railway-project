using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;

namespace Login_Form
{
    public partial class login : Form
    {
        public string conString = "Data Source=ABDALLA;Initial Catalog=railwayres;Integrated Security=True";
        private SqlCommand cmd;
        

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int x;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            cmd = new SqlCommand("select * from passenger where email ='" + mail_txb.Text + "' and P_password='" + textBoxpass.Text + "'",con);
            con.Open();
            SqlDataReader dr1 =cmd.ExecuteReader();


            

           



            if (dr1.Read())
            {
                    menu_user mu = new menu_user();
                    mu.Show();
                    this.Close();

            }
            else if (mail_txb.Text == "admin" && textBoxpass.Text == "admin")
            {
                admin admpage = new admin();
                admpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect data");
            }
            con.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            register sp = new register();
            sp.Show();
            this.Close();
        }
    }
}
