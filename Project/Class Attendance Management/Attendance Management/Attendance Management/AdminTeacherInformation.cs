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
    public partial class AdminTeacherInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminTeacherInformation()
        {
            InitializeComponent();
            BindGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminTeacherInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sT_LOGINDataSet7.TR_INFORMATION' table. You can move, or remove it, as needed.
            this.tR_INFORMATIONTableAdapter.Fill(this.sT_LOGINDataSet7.TR_INFORMATION);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[8].Value);


        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }




        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from tr_information";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            ///Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[8];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from tr_information where teacherid=@teacherid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@teacherid",textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Delete Successfully ! ");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Delete Failed ! ");
            }
            con.Close();

        }

        private void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            pictureBox1.Image = Properties.Resources.download1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ad = new AdminHome();
            ad.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Blue;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
        }
    }
}
