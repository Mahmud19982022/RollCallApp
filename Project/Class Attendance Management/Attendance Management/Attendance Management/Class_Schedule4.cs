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
    public partial class Class_Schedule4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Class_Schedule4()
        {
            InitializeComponent();
        }

        private void Class_Schedule4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sT_LOGINDataSet9.CLASS_SCHEDULE' table. You can move, or remove it, as needed.
            this.cLASS_SCHEDULETableAdapter.Fill(this.sT_LOGINDataSet9.CLASS_SCHEDULE);

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Portal tp = new Teacher_Portal();
            tp.Show();
        }
    }
}
