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
    public partial class Teacher_Information : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Teacher_Information()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";

            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into tr_information values(@teacherid, @teachername, @age,@department, @religion, @presentaddress, @phonenumber, @bloodgroup,@img)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@teacherid", textBox1.Text);
            cmd.Parameters.AddWithValue("@teachername", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@department", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@religion", textBox5.Text);
            cmd.Parameters.AddWithValue("@presentaddress", textBox6.Text);
            cmd.Parameters.AddWithValue("@phonenumber", textBox7.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", textBox8.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Information Inserted Successfully ! ");
                ResetControl();
              
            }
            else
            {
                MessageBox.Show("Information not Inserted ! ");
            }
            con.Close();
        }

        private void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
             comboBox1.SelectedIndex=-1;
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            pictureBox1.Image = Properties.Resources.download1;
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Portal tp = new Teacher_Portal();
            tp.Show();
        }

        private void Teacher_Information_Load(object sender, EventArgs e)
        {

        }
    }
}
