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
    public partial class viewCourseStudent : Form
    {
        public viewCourseStudent()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "SELECT * FROM `courses` WHERE course_id = " + Global.courseID;
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // view_title_input.Text = reader.GetString(1);
                    courseTitle.Text = reader["title"].ToString();
                    description.Text = reader["description"].ToString();
                    instrutName.Text = "By " + reader["instructor"].ToString();
                    courseContent.Text = reader["content"].ToString();
                }

                databaseconnection.Close();


            }
            else{
                MessageBox.Show("There seems to be an error with the SQL Connection");
                reader.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewCourseStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
