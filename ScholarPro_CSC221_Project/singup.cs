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
    public partial class signup : Form
    {
        static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(chars.Length);
                stringBuilder.Append(chars[randomIndex]);
            }

            return stringBuilder.ToString();
        }
        public signup()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "" || emailField.Text == "" || pwordField.Text == "" )
            {
                MessageBox.Show("A name, email or password field cannot be blank! Please try again.");
                return;
            }
            if (pwordField.Text != pwordConfrmField.Text)
            {
                MessageBox.Show("Confirm password field is not correct! Please try again.");
                return;
            }
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "insert into users values (' " + GenerateRandomString(10) + " ',' " + nameField.Text + " ',' " + emailField.Text + " ',' " + pwordField.Text + " ')";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Signup successful!");

            login f1 = new login();
            f1.Show();
            Visible = false;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}