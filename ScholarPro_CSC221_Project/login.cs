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

namespace ScholarPro_CSC221_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            label6.Text = Global.userType + " Login";
            if (Global.userType == "Admin") {
                signupLink.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( emailField.Text == "" || pwordField.Text == "")
            {
                MessageBox.Show("An email or password field cannot be blank! Please try again.");
                return;
            }

            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "select email, password from users where email=' " + emailField.Text + " ' and password= ' " + pwordField.Text + " '";
            if (Global.userType == "Admin") {
                querystr = "select email, password from admin where email='" + emailField.Text + "' and password= '" + pwordField.Text + "'";

            }
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
        
                MessageBox.Show("Logged in Successfully");

                databaseconnection.Close();

                dashboard add = new dashboard();
                add.Show();
                Visible = false;
            }
            else
                MessageBox.Show(Global.userType + " user Not found \r\nCheck your Credentials and try again!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signupLink_Click(object sender, EventArgs e)
        {
            signup f2 = new signup();
            f2.Show();
            Visible = false;
        }
    }
}
