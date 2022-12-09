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
    public partial class admin_users: Form
    {
        SqlConnection con =new SqlConnection(@"Data Source=ABDALLA;Initial Catalog=railwayDB;Integrated Security=True");
        SqlDataAdapter da=new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder cmdBuilder;
        public admin_users(object dt1)
        {
            InitializeComponent();
            da = new SqlDataAdapter("SELECT * from Users",con);
            da.Fill(dt);
            usersGrid.DataSource = dt;




        }

       

        private void admin_Trains_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railwayDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.railwayDBDataSet.Users);

        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            cmdBuilder=new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Passed successfully","Data Changes",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void usersnsmepnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
