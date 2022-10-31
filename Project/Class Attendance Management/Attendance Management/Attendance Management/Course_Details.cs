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
    public partial class Course_Details : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Course_Details()
        {
            InitializeComponent();
            BindGridView();
            //ResetContro();

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into course_details values(@courseid,@coursename,@coursecredit)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@courseid", textBox1.Text);
            cmd.Parameters.AddWithValue("@coursename", textBox2.Text);
            cmd.Parameters.AddWithValue("@coursecredit", comboBox1.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully ! ");
                BindGridView();
               

            }
            else
            {
                MessageBox.Show("Data not Inserted ! ");
            }
            con.Close();
          
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from course_details";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DROP_APPLICATION da = new DROP_APPLICATION();
            da.Show();

           
        }

    

       
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor =Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;

          
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke; ;
            button2.ForeColor = Color.Blue;
           
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke; 
            button4.ForeColor = Color.Blue;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal stu = new Student_Portal();
            stu.Show();
        }

       

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

