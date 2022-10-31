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
    public partial class Result_Uploadcs : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Result_Uploadcs()
        {
            InitializeComponent();
            BindGridView();
            ResetControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into result_upload values(@coursename,@marks,@grade)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@coursename", textBox1.Text);
            cmd.Parameters.AddWithValue("@marks", textBox2.Text);
            cmd.Parameters.AddWithValue("@grade", comboBox1.Text);
          

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Result Inserted Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Result  not Inserted ! ");
            }
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from result_upload";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex=-1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update result_upload  set  coursename=@coursename, marks=@marks, grade=@grade where coursename=@coursename";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@coursename", textBox1.Text);
            cmd.Parameters.AddWithValue("@marks", textBox2.Text);
            cmd.Parameters.AddWithValue("@grade", comboBox1.SelectedItem);

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Result Updated Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Result not Updated ! ");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Portal tp = new Teacher_Portal();
            tp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from result_upload where coursename=@coursename";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("coursename", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Result Deeted  Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Result Deleted Failed ! ");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
