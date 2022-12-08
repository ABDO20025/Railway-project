using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection;

namespace Login_Form
{
    public partial class register : Form
    {

       
        public register()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=ABDALLA;Initial Catalog=railwayDB;Integrated Security=True";
        private SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            

            if (nametxb.Text!=""&&user_idtxb.Text!=""&&gendercmb.Text!=""&& dateTimePickerdob.Text!=""&& pintxb.Text != "" && mobiletxb.Text != "" && u_passtxb.Text != "" && citytxb.Text != "" &&u_passtxb.Text==cpasstxb.Text&&statetxb.Text!="")
            {





                cmd = new SqlCommand("insert into Users values('" + user_idtxb.Text + "', '" +nametxb.Text + "', '" + gendercmb.Text + "', '" + this.dateTimePickerdob.Value.Year.ToString() + "',  '" + mobiletxb.Text + "', '" + statetxb.Text + "', '" + citytxb.Text + "', '" + pintxb.Text + "', '" + u_passtxb.Text + "')", con); 
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("please sign in with your account data", "Account created succesfully  ");
                

            }
        }

        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sig_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            login l = new login();
            l.Show();
            

        }

       

        
    }
}
