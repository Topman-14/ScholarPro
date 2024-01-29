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
    public partial class viewCourse : Form
    {
        public viewCourse()
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
                    view_title_input.Text = reader["title"].ToString();
                    view_desc_input.Text = reader["description"].ToString();
                    view_instructor_input.Text = reader["instructor"].ToString();
                    view_content_input.Text = reader["content"].ToString();
                }

                databaseconnection.Close();


            }
            else
                //MessageBox.Show("User Not found");
                view_title_input.Text = Global.courseID;
                reader.Close();
        }

        private void test_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //dashboard dash = new dashboard();
            //dash.Show();
            Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "UPDATE courses SET title = @title, description = @description, instructor = @instructor, content = @content WHERE course_id = @id";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@title", view_title_input.Text);
            databasecommand.Parameters.AddWithValue("@description", view_desc_input.Text);
            databasecommand.Parameters.AddWithValue("@instructor", view_instructor_input.Text);
            databasecommand.Parameters.AddWithValue("@content", view_content_input.Text);
            databasecommand.Parameters.AddWithValue("@id", Global.courseID);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Course updated successfully!");
            Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "DELETE FROM courses WHERE course_id = @id";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@id", Global.courseID);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Course deleted successfully!");
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_content_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
