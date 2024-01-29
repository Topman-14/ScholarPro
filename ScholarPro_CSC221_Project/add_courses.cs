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
    public partial class addCourse : Form
    {
        public addCourse()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "123456789";
            StringBuilder stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(chars.Length);
                stringBuilder.Append(chars[randomIndex]);
            }

            return stringBuilder.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void title_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (title_input.Text == "" || desc_input.Text == "" || instructor_input.Text == "" || content_input.Text == "") {
                MessageBox.Show("A blank field cannot be updated! Please try again");
                return;
            }
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "insert into courses values (' " + GenerateRandomString(3) + " ',' " + title_input.Text + " ',' " + desc_input.Text + " ',' " + instructor_input.Text + " ',' " + content_input.Text + " ')";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Course successfully added!");
            Visible = false;
        }

        private void content_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void addCourse_Load(object sender, EventArgs e)
        {

        }
        }
    }

