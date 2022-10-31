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
    public partial class Attendance : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Attendance()
        {
            InitializeComponent();
            BindGridView();
            ResetControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into attendance values (@studentid,@studentname,@status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@studentid", textBox1.Text);
            cmd.Parameters.AddWithValue("@studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@status", comboBox1.Text);
   

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Attendance Given  Successfully ! ");
                 BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Attendance Not Given ! ");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Portal tp = new Teacher_Portal();
            tp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update attendance set studentid=@studentid, studentname=@studentname, status=@status where studentid=@studentid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@studentid", textBox1.Text);
            cmd.Parameters.AddWithValue("@studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@status", comboBox1.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Attendance Updated Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Attendance  not Updated ! ");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetControl();
        }


        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from  attendance";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }



        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from attendance where studentid=@studentid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("studentid", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Attendance Deleted Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Attendance  Not Deleted");

            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
