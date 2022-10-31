using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace Attendance_Management
{
    public partial class Class_Schedule : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Class_Schedule()
        {
            InitializeComponent();
            BindGridView();
            ResetControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into class_schedule values(@courseid,@coursename,@section,@time,@roomno)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@courseid", textBox1.Text);
            cmd.Parameters.AddWithValue("@coursename", textBox2.Text);
            cmd.Parameters.AddWithValue("@section", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@time", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@roomno", comboBox3.SelectedItem);

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Class Schedule Inserted Successfully ! ");
                 BindGridView();
                 ResetControl();
            }
            else
            {
                MessageBox.Show("Class Schedule  Not Inserted ! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from class_schedule";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "delete from class_schedule where courseid=@courseid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("courseid", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Class Schedule  Deleted Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Class Schedule  Not Deleted");

            }
            


            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update class_schedule set courseid=@courseid, coursename=@coursename, section=@section, time=@time, roomno=@roomno where courseid=@courseid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@courseid", textBox1.Text);
            cmd.Parameters.AddWithValue("@coursename", textBox2.Text);
            cmd.Parameters.AddWithValue("@section", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@time", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@roomno",comboBox3.SelectedItem);
         

            con.Open();

            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Class Schedule Updated Successfully ! ");
                  BindGridView();
                  ResetControl();
            }
            else
            {
                MessageBox.Show("Class Schedule not Updated ! ");
            }
            con.Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

        }

        private void Class_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sT_LOGINDataSet10.CLASS_SCHEDULE' table. You can move, or remove it, as needed.
            this.cLASS_SCHEDULETableAdapter.Fill(this.sT_LOGINDataSet10.CLASS_SCHEDULE);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
            button4.ForeColor = Color.Blue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = Color.Blue;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.WhiteSmoke;
            button5.ForeColor = Color.Blue;
        }
    }
}