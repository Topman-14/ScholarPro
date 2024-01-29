using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarPro_CSC221_Project
{
    public partial class access_login : Form
    {
        public access_login()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Global.userType = "Student";
            signup f2 = new signup();
            f2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.userType = "Student";
            login f1 = new login();
            f1.Show();
            Visible = false;
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            Global.userType = "Admin";
            login f1 = new login();
            f1.Show();
            Visible = false;
        }

        private void access_login_Load(object sender, EventArgs e)
        {

        }
    }
}
