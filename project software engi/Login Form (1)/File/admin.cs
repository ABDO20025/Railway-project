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

namespace Login_Form
{
    public partial class admin : Form
        
    {
        SqlCommandBuilder cmd;
        SqlConnection conn=new SqlConnection("Data Source=ABDALLA;Initial Catalog=railwayDB;Integrated Security=True");

        private object dt;

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trainDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_users adU =new admin_users(dt);
            adU.Show();

        }

        private void trainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void passengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_passenger ap = new admin_passenger();
            ap.Show();
        }

        private void mainTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
