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
    
    public partial class Result : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Result()
        {
            InitializeComponent();
            BindGridView();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from result_upload";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal sp = new Student_Portal();
            sp.Show();
        }
    }
}
