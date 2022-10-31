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
    public partial class adminstudentinfo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public adminstudentinfo()
        {
            InitializeComponent();
            BindGridView();
            ResetControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from students where studentid=@studentid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("studentid", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Information Deleted Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Information Not Deleted");
               
            }
            con.Close();
        }

        private void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text=" ";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        void BindGridView()
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from students";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.RowTemplate.Height = 50;
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

        private void adminstudentinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sT_LOGINDataSet13.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter3.Fill(this.sT_LOGINDataSet13.Students);
            // TODO: This line of code loads data into the 'sT_LOGINDataSet12.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter2.Fill(this.sT_LOGINDataSet12.Students);
            // TODO: This line of code loads data into the 'sT_LOGINDataSet11.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter1.Fill(this.sT_LOGINDataSet11.Students);
            // TODO: This line of code loads data into the 'sT_LOGINDataSet8.Students' table. You can move, or remove it, as needed.
            // this.studentsTableAdapter.Fill(this.sT_LOGINDataSet8.Students);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();    
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Blue;
        }
    }
}