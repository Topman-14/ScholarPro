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

    public partial class dashboard : Form
    {
        private DataTable dataTable;
        private Timer timer;

        public dashboard()
        {
            InitializeComponent();
            if (Global.userType == "Student"){
                add_course.Visible = false;
                userMsg.Text = "Double click a table cell to view the course details";
                userLabel.Text = Global.userType + " Dashboard";
            }

            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += dashboard_Load;   // Refresh the courses table every 2 seconds
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (search_input.Text == ""){
                MessageBox.Show("Please Input a value before searching");
                return;
            }

            string searchQuery = "'%" + search_input.Text + "%'";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "select course_id, title, instructor from courses where title like " + searchQuery;
            //string querystr = "select course_id, title, instructor from courses";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            addCourse add = new addCourse();
            add.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "select course_id, title, instructor from courses";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Global.courseID = row.Cells[0].Value.ToString();

            if (Global.userType == "Student") {
                viewCourseStudent viewStu = new viewCourseStudent();
                viewStu.Show();
            } else {
                viewCourse view = new viewCourse();
                view.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer.Start();
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=scholarpro_db;";
            string querystr = "select course_id, title, instructor from courses";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            access_login accessLog = new access_login();
            accessLog.Show();
            Visible = false;
        }
    }
}
