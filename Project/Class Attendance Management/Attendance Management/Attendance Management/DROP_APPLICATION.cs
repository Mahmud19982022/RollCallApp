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
    public partial class DROP_APPLICATION : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public DROP_APPLICATION()
        {
            InitializeComponent();
            BindGridView();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from course_details where courseid=@courseid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("courseid", textBox4.Text);
            con.Open();
            int a  = cmd.ExecuteNonQuery();//0 1
         
            if (a > 0)
            {
                MessageBox.Show("Course Droped Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Course Droped Failed ! ");
            }
            con.Close();
        }

       

        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from course_details";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 50;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            ResetControl();
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Blue;
        }

        private void ResetControl()
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course_Details cd = new Course_Details();
            cd.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = Color.Blue;
        }
    }
    }
