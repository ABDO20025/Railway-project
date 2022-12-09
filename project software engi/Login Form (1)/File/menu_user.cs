using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class menu_user : Form
    {
        public menu_user()
        {
            InitializeComponent();
        }

        private void menu_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservations r = new reservations();
            r.Show();


        }
    }
}
