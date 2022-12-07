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
        public string conString = "Data Source=ABDALLA;Initial Catalog=railwayres;Integrated Security=True";
        private SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            

            if (fname.Text!=""&&lname.Text!=""&&gender.Text!=""&& dateTimePickerdob.Text!=""&& address.Text != "" && phone.Text != "" && password.Text != "" && SSn.Text != "" &&password.Text==cpass.Text&&mail.Text!="")
            {

                



                cmd = new SqlCommand("insert into passenger(P_Fname, lastname, gender, P_address, mobile, email, SSN, date_of_Birth, P_password) values('"+fname.Text+"', '"+lname.Text+"', '"+gender.Text+"', '"+address.Text+"',  '"+phone.Text+"', '"+mail.Text+"', '"+SSn.Text+"', '"+ this.dateTimePickerdob.Text+"', '"+password.Text+"')", con);
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
            
        }

        private void dateTimePickerdob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
